using libMessage;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace helper
{
    static class Program
    {
        static void Main()
        {
            Send post = new Send();
            string startupPath = Application.StartupPath;
            string resourcePath = Directory.GetParent(startupPath).FullName + "\\res\\";
            string filePath = startupPath + "\\markdown.exe";
            // information
            Console.WriteLine("Tap 키를 눌러 자동완성을 사용할 수 있습니다.");
            Console.WriteLine("all 를 입력하시면 저장된 도움말을 확인할 수 있습니다.");
            Console.WriteLine("종료하시려면 Control + V 를 누르거나 exit 을 입력하세요.");
            // get .md file name
            DirectoryInfo di = new DirectoryInfo(resourcePath);
            var mdFile = di.GetFiles("*.md");
            int n = mdFile.Length;
            if (n == 0)
            {
                post.sendMessage("h|" + "file does not exist.");
                return;
            }
            string[] data = new string[n];
            int i = 0;
            foreach (var item in di.GetFiles("*.md"))
            {
                data[i] = Path.GetFileNameWithoutExtension(item.Name);
                i++;
            }
            // auto complete
            while (true) {
                var builder = new StringBuilder();
                var input = Console.ReadKey(intercept: true);
                while (input.Key != ConsoleKey.Enter)
                {
                    var currentInput = builder.ToString();
                    if (input.Key == ConsoleKey.Tab)
                    {
                        var match = data.FirstOrDefault(item => item != currentInput && item.StartsWith(currentInput, true, CultureInfo.InvariantCulture));
                        if (string.IsNullOrEmpty(match))
                        {
                            input = Console.ReadKey(intercept: true);
                            continue;
                        }
                        ClearCurrentLine();
                        builder.Clear();
                        Console.Write(match);
                        builder.Append(match);
                    }
                    else
                    {
                        if (input.Key == ConsoleKey.Backspace && currentInput.Length > 0)
                        {
                            builder.Remove(builder.Length - 1, 1);
                            ClearCurrentLine();
                            currentInput = currentInput.Remove(currentInput.Length - 1);
                            Console.Write(currentInput);
                        }
                        else
                        {
                            var key = input.KeyChar;
                            builder.Append(key);
                            Console.Write(key);
                        }
                    }
                    input = Console.ReadKey(intercept: true);
                }
                Console.Write("\n");
                string result = builder.ToString();
                if (result.Equals("exit")) break;
                if (result.Equals("all"))
                {
                    for(int j = 0; j < n-1; j++)
                    {
                        Console.Write("[" + data[j] + "], ");
                    }
                    Console.Write("[" + data[n-1] + "]\n");
                    continue;
                }
                // execute markdown.exe *.md
                bool exist = true;
                for(int j = 0; j < n; j++) if (data[j] == result) exist = false;
                if (exist)
                {
                    post.sendMessage("h|" + "file name does not exist.");
                    continue;
                }
                Process.Start(filePath, result);
            }
        }
        private static void ClearCurrentLine()
        {
            var currentLine = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLine);
        }
    }
}
