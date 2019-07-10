using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            // Олег Сергеевич, здравствуйте хотел еще повозиться с цветами, но в силу того что я только сегодня узнал от одногрупников 
            // про это задание я не успел с ними разобраться, в планах было отображение цветов на игровом поле так же,
            // как в пункте меню 1
            string[] craftItems = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            int key;
            do
            {
                int y = 2, x = 50;
                Console.Clear();
                Console.WriteLine("1. Показать рецепты \n2. Добавить материал \n3. Очистить кузницу \n4. Сверстать \n5. Покинуть кузницу ");
                Console.SetCursorPosition(x, y++);
                for (int i = 0; i < 9; i++)
                {
                    if (i > 0 && i % 3 == 0)
                    {
                        Console.Write("\n\n");
                        Console.SetCursorPosition(x, y++);
                    }
                    Console.Write("   " + craftItems[i] + "   ");
                }
                if (int.TryParse(Console.ReadLine(), out key))
                {
                    switch (key)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.SetCursorPosition(3, 0); Console.WriteLine("SSS");
                                Console.SetCursorPosition(3, 1);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 1);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 1);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(3, 2);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 2);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 2);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(0, 4);
                                Console.WriteLine("Каменная кирка");


                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(3, 6); Console.WriteLine("GGG");
                                Console.SetCursorPosition(3, 7);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 7);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 7);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(3, 8);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 8);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 8);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(0, 9);
                                Console.WriteLine("Золотая кирка");


                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(3, 11); Console.WriteLine("III");
                                Console.SetCursorPosition(3, 12);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 12);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 12);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(3, 13);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("0"); Console.SetCursorPosition(4, 13);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("T"); Console.SetCursorPosition(5, 13);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("0");
                                Console.SetCursorPosition(0, 14);
                                Console.WriteLine("Железная кирка");
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                int material;
                                int elementNumber;
                                Console.WriteLine("Выберите ячейку куда будет вставлен материал(от 1 до 9)");
                                elementNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nВыберите материал который нужно добавить \n1. Дерево \n2. Камень \n3. Золото \n4. Железо");
                                if (int.TryParse(Console.ReadLine(), out material))
                                {
                                    switch (material)
                                    {
                                        case 1:
                                            {
                                                Tree tree = new Tree();
                                                craftItems[elementNumber - 1] = tree.GetTreeSymbol();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Stone stone = new Stone();
                                                craftItems[elementNumber - 1] = stone.GetStoneSymbol();
                                                break;
                                            }
                                        case 3:
                                            {
                                                Gold gold = new Gold();
                                                craftItems[elementNumber - 1] = gold.GetGoldSymbol();
                                                break;
                                            }
                                        case 4:
                                            {
                                                Iron iron = new Iron();
                                                craftItems[elementNumber - 1] = iron.GetIronSymbol();
                                                break;
                                            }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, неверный номер материала");
                                }
                                break;
                            }
                        case 3:
                            {
                                for(int i = 0; i < 9; i++)
                                {
                                    craftItems[i] = "0";
                                }
                            }
                            break;
                        case 4:
                            {
                                Tree tr = new Tree();
                                Stone st = new Stone();
                                Gold gl = new Gold();
                                Iron ir = new Iron();
                                if (craftItems[0] == st.GetStoneSymbol() && craftItems[1] == st.GetStoneSymbol() && craftItems[2] == st.GetStoneSymbol()
                                    && craftItems[4] == tr.GetTreeSymbol() && craftItems[7] == tr.GetTreeSymbol())
                                {
                                    Console.WriteLine("Поздравляем Вы скрафтили каменную кирку");
                                }
                                else if(craftItems[0] == gl.GetGoldSymbol() && craftItems[1] == gl.GetGoldSymbol() && craftItems[2] == gl.GetGoldSymbol()
                                    && craftItems[4] == tr.GetTreeSymbol() && craftItems[7] == tr.GetTreeSymbol())
                                {
                                    Console.WriteLine("Поздравляем Вы скрафтили золотую кирку");
                                }
                                else if (craftItems[0] == ir.GetIronSymbol() && craftItems[1] == ir.GetIronSymbol() && craftItems[2] == ir.GetIronSymbol()
                                    && craftItems[4] == tr.GetTreeSymbol() && craftItems[7] == tr.GetTreeSymbol())
                                {
                                    Console.WriteLine("Поздравляем Вы скрафтили железную кирку");
                                }
                                else
                                {
                                    Console.WriteLine("Ознакомтесь пожалуйста с рецептами, вы ничего не скрафтили");
                                }
                            }
                            break;
                        case 5:
                            {
                                break;
                            }
                        default:
                            Console.WriteLine("Введена неверная команда");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка, неверная команда!!!");
                }
                Console.ReadLine();
            } while (key != 0);
        }
    }
}
