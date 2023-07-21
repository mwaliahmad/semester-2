using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BDMS.DL;
namespace BDMS.UI
{
    public class Common
    {
        public RecipientUI RecipientUI
        {
            get => default;
            set
            {
            }
        }

        public DonorUI DonorUI
        {
            get => default;
            set
            {
            }
        }

        public EmployeeUI EmployeeUI
        {
            get => default;
            set
            {
            }
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        public static void Header()
        {
            Console.Clear();
            Datetime();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("             ____  _                 _   _____                    _   _              ");
            Console.WriteLine("            |  _ \\| |               | | |  __ \\                  | | (_)                  ");
            Console.WriteLine("            | |_) | | ___   ___   __| | | |  | | ___  _ __   __ _| |_ _  ___  _ __         ");
            Console.WriteLine("            |  _ <| |/ _ \\ / _ \\ / _` | | |  | |/ _ \\| '_ \\ / _` | __| |/ _ \\| '_ \\         ");
            Console.WriteLine("            | |_) | | (_) | (_) | (_| | | |__| | (_) | | | | (_| | |_| | (_) | | | |         ");
            Console.WriteLine("            |____/|_|\\___/ \\___/ \\__,_| |_____/ \\___/|_| |_|\\__,_|\\__|_|\\___/|_| |_|          ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  __  __                                                   _      _____           _               ");
            Console.WriteLine(" |  \\/  |                                                 | |    / ____|         | |               ");
            Console.WriteLine(" | \\  / | __ _ _ __   __ _  __ _  ___ _ __ ___   ___ _ __ | |_  | (___  _   _ ___| |_ ___ _ __ ___  ");
            Console.WriteLine(" | |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '_ ` _ \\ / _ \\ '_ \\| __|  \\___ \\| | | / __| __/ _ \\ '_ ` _ \\  ");
            Console.WriteLine(" | |  | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_   ____) | |_| \\__ \\ ||  __/ | | | | | ");
            Console.WriteLine(" |_|  |_|\\__,_|_| |_|\\__,_|\\__, |\\___|_| |_| |_|\\___|_| |_|\\__| |_____/ \\__, |___/\\__\\___|_| |_| |_| ");
            Console.WriteLine("                            __/ |                                        __/ |                       ");
            Console.WriteLine("                           |___/                                        |___/                      ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Datetime()
        {
            DateTime now = DateTime.Now;
            Console.SetCursorPosition(78, 1);
            Console.WriteLine(now);
        }
        public static void Menu(string menu, string subMenu)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  " + menu + " > " + subMenu);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Back(string line)
        {
            Console.WriteLine();
            Console.WriteLine(line);
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine("Press any key for back...");
            Console.ReadKey();
        }
        public static int Option(int range, string text)
        {
            int y = Console.CursorTop;
            string option;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                option = Console.ReadLine();

            } while (!IsNum(option, range));

            return int.Parse(option);
        }
        public static string ContactCnic(int length, string text)
        {
            int y = Console.CursorTop;
            string option;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                option = Console.ReadLine();

            } while (!IsNum(length, option));

            return option;
        }
        public static string Age(string text)
        {
            int y = Console.CursorTop;
            string option;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                option = Console.ReadLine();

            } while (!IsNum(option));

            return option;
        }
        public static string AlphaInput(string text)
        {
            int y = Console.CursorTop;
            string input;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                input = Console.ReadLine();

            } while (!IsAlpha(input));

            return input;
        }
        public static string Username(string text)
        {
            int y = Console.CursorTop;
            string input;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                input = Console.ReadLine();

            } while (EmployeeCRUD.SearchEmployee(input) != null);

            return input;
        }
        public static string Password(string text)
        {
            int y = Console.CursorTop;
            string input;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                input = Console.ReadLine();

            } while (!PasswordCheck(input));

            return input;
        }
        public static string BG(string text)
        {
            int y = Console.CursorTop;
            string input;
            do
            {
                ClearLine(y);
                ClearLine(y + 1);
                Console.SetCursorPosition(0, y);
                Console.Write(text);
                input = Console.ReadLine();

            } while (!BGCheck(input));

            return input;
        }
        public static bool IsNum(string option, int range)
        {
            bool isValid = false;
            if (int.TryParse(option, out int number))
            {
                if (number <= range && number > 0)
                {
                    isValid = true;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return isValid;
        }
        public static bool IsNum(string option)
        {
            bool isValid = false;
            if (int.TryParse(option, out int number))
            {
                if (number <= 60 && number > 17)
                {
                    isValid = true;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return isValid;
        }
        public static bool IsNum(int length, string option)
        {
            bool isValid = false;
            if (long.TryParse(option, out long number) && option.Length == length)
            {
                if (number > 0)
                {
                    isValid = true;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return isValid;
        }
        public static bool PasswordCheck(string option)
        {
            bool isValid = false;
            if (option.Length == 8)
            {
                isValid = true;
            }
            if (!isValid)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return isValid;
        }
        public static bool IsAlpha(string input)
        {
            bool flag = false;
            flag = input.All(Char.IsLetter);
            if (!flag)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return flag;
        }
        public static bool BGCheck(string input)
        {
            string[] BG = new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            bool flag = false;
            if (BG.Contains(input))
            {
                flag = true;
            }

            if (!flag)
            {
                Console.WriteLine("Wrong Input...Press any Key to Continue");
                Console.ReadKey();
            }
            return flag;
        }

        public static void ClearLine(int y)
        {
            Console.SetCursorPosition(0, y);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }
        }
        public static void MessageBox(string line)
        {
            Console.WriteLine();
            Console.WriteLine(line);
            Thread.Sleep(350);
        }
    }
}
