using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlAssistant
{
    public static class KeyStrokeBuilder        
    {
        public static string BuildFrom(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                throw new ArgumentException($"Keystroke: {nameof(inputString)} does not accept an empty string");

            var uppercaseString = inputString.ToUpper();

            var mappedKeyActions = new List<MappedKeyAction>();
            foreach(char c in uppercaseString)
            {
                mappedKeyActions.Add(new MappedKeyAction(c));
            }

            return String.Join(Environment.NewLine, mappedKeyActions.Select(a => a.ToString()));
        }
    }
}
