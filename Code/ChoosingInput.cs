class ChoosingInput
    {
        public string Line {get;init;}
        public ChoosingInput()
        {
            Console.WriteLine("Print \'1\' if you want to input string");
            Console.WriteLine("Else the string will be generated with random chars");
            if (SelectFilling())
            {
                var line = new InputString();
                this.Line = line.Line;
            }
            else
            {
                var line = new RandomString();
                this.Line = line.ConcateWordsToEnglishString();
            }
        }
        private bool SelectFilling()
        {
            string? choise = Console.ReadLine();
            if (choise == "1")
            {
                return true;
            }
            return false;
        }
    }