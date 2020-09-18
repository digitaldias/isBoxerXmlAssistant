using System;
using System.Linq;
using System.Reflection;

namespace XmlAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args.Any(a => 
                             a.Equals("--help", StringComparison.InvariantCultureIgnoreCase) ||
                             a.Equals("-h", StringComparison.InvariantCultureIgnoreCase))
              )
            {
                ShowHelp();
            }
        }

        private static void ShowHelp()
        {
            var helpMessage = $"xmlAssistant v{Assembly.GetEntryAssembly().GetName().Version}" + Environment.NewLine +
                               "---------------------" + Environment.NewLine +
                               "Syntax:" + Environment.NewLine +
                               "xmlAssistant <argument> [parameters]" + Environment.NewLine + Environment.NewLine +
                               "Supported Arguments: " + Environment.NewLine +
                               "createKeyStrokes 'input string'    : Creates a sequence of MappedKeyActions of type 'KeyStroke' where each character in the input string are a single keystroke " + Environment.NewLine;                               
                               ;
              Console.WriteLine(helpMessage);
        }
    }
}
