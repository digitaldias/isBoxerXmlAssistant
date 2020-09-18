namespace XmlAssistant
{
    internal class MappedKeyAction
    {
        private char character;

        public MappedKeyAction(char c)
        {
            character = c;
        }

        public override string ToString()
        {
            var name = "" + character;
            var code = string.Empty;

            if(character == ' ')
            {
                name = "SPACE";
                code = "<Code>57</Code>";
            }            
            return
@$"<MappedKeyAction xsi:type=""Keystroke"">
    <Combo>
        <Combo>{name}</Combo>
        <Key>
            <Key>{name}</Key>{code}
        </Key>
    </Combo>
</MappedKeyAction>";
        }
    }
}