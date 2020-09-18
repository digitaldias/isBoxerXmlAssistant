namespace XmlAssistant
{
    internal class MappedKeyAction
    {
        private char c;

        public MappedKeyAction(char c)
        {
            this.c = c;
        }

        public override string ToString()
        {
            return 
@$"<MappedKeyAction xsi:type=""KeyStroke"">
    <Combo>
        <Combo>{c}</Combo>
        <Key>
            <Key>{c}</Key>
            <Code>{(int)c}</Code>
        </Key>
    </Combo>
</MappedKeyAction>";
        }
    }
}