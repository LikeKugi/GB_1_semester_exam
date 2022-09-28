class RandomString
    {
        private readonly char[] englishLetters = Enumerable.Range('a', 'z'-'a').Select(n=>((char)n)).ToArray();
        private readonly char[] russianLetters = Enumerable.Range('а', 'я'-'а').Select(n=>((char)n)).ToArray();
        private readonly char[] numbers = Enumerable.Range('0', '9'-'0').Select(n=>((char)n)).ToArray();
        private readonly int wordLength = 9;
        public RandomString() {}
        public string ConcateWordsToEnglishString()
        {
            string line = string.Empty;
            line += CreateRandomNumberWord();
            var wordsCount = rd.Next(7,50);
            for (int i = 0; i < wordsCount; i++)
            {
                line = string.Concat(line + " ", CreateRandomEnglishWord());
            }
            return line;
        }
        public string ConcateWordsToRussianString()
        {
            string line = string.Empty;
            line += CreateRandomNumberWord();
            var wordsCount = rd.Next(7,50);
            for (int i = 0; i < wordsCount; i++)
            {
                string.Concat(line + " ", CreateRandomRussianWord());
            }
            return line;
        }
        private string CreateRandomEnglishWord()
        {
            string word = string.Empty;
            var currentWordLength = rd.Next(1,wordLength);
            word = Enumerable.Range(1,currentWordLength).Aggregate("",(a,n)=>a+=englishLetters[rd.Next(1,englishLetters.Length)]).ToString();
            return word;
        }
        private string CreateRandomRussianWord()
        {
            string word = string.Empty;
            var currentWordLength = rd.Next(1,wordLength);
            word = Enumerable.Range(1,currentWordLength).Aggregate("",(a,n)=>a+=russianLetters[rd.Next(1,russianLetters.Length)]).ToString();
            return word;
        }
        private string CreateRandomNumberWord()
        {
            string word = string.Empty;
            var currentWordLength = rd.Next(1,wordLength);
            word = Enumerable.Range(1,currentWordLength).Aggregate("",(a,n)=>a+=numbers[rd.Next(1,numbers.Length)]).ToString();
            return word;
        }
        static Random rd => new Random();
    }