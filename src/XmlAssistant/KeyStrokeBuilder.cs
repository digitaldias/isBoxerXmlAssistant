using System;
using System.Collections.Generic;
using System.Linq;

namespace XmlAssistant
{
    public static class KeyStrokeBuilder
    {
        public static string BuildFrom(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                throw new ArgumentException($"Keystroke: {nameof(inputString)} does not accept an empty string");

            var mappedKeyActions = new List<MappedKeyAction>();
            foreach(char c in inputString.ToUpper())
            {
                mappedKeyActions.Add(new MappedKeyAction(c));
            }
            return String.Join(Environment.NewLine, mappedKeyActions.Select(a => a.ToString()));
        }
    }
}
