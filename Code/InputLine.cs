class InputLine
    {
        public string Line {get;init;} 
        public InputLine()
        {
            this.Line = CreateLine();
        }
        private string CreateLine()
        {
            var words = string.Empty;
            do
            {
                Console.WriteLine("Please enter not empty line");
                words = Console.ReadLine();
            } while(string.IsNullOrWhiteSpace(words));
            return words;
        }
    }