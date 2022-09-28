class InputString
    {
        public string Line {get;init;} 
        public InputString()
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