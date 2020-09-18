using System;
using System.Linq;
using System.Reflection;

namespace XmlAssistant
{
    static class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args.Any(a => 
                             a.Equals("--help", StringComparison.InvariantCultureIgnoreCase) ||
                             a.Equals("-h", StringComparison.InvariantCultureIgnoreCase))
              )
            {
                ShowHelp();
                return;
            }

            try
            {
                ExecuteOperation(args);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(Environment.NewLine + "Done.");
        }

        public static void ExecuteOperation(string[] args)
        {
            var operation = args[0];
            switch (operation.ToLower())
            {
                case "keystrokes":
                    Console.WriteLine(KeyStrokeBuilder.BuildFrom(args[1]));
                    break;

                default:
                    Console.WriteLine("Operation not recognized");
                    break;
            }
        }

        private static void ShowHelp()
        {
            var helpMessage = $"xmlAssistant v{Assembly.GetEntryAssembly().GetName().Version}" + Environment.NewLine +
                               "---------------------" + Environment.NewLine +
                               "Syntax:" + Environment.NewLine +
                               "xmlAssistant <argument> [parameters]" + Environment.NewLine + Environment.NewLine +
                               "Supported Operations: " + Environment.NewLine +
                               "keyStrokes <input string> : Creates a sequence of MappedKeyActions of type 'KeyStroke' " + Environment.NewLine +
                               "                            where each character in the input string are a single keystroke " + Environment.NewLine +
                               "                            Input string is a required argument to keyStrokes, use double quotes.";

                               ;
              Console.WriteLine(helpMessage);
        }
    }
}
