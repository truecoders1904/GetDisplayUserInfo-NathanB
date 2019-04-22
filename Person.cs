using System;

namespace GetDisplay

{
    class Person
    {
        public string Name { get; set; }
        public int FavoriteNumber { get; set; }
        public int NumberOfKids { get; set; }
        public string FavoriteAnimal { get; set; }



        public string AnswerQuestion(string question)
        {
            Console.WriteLine($"Hey {Name}, I have a question for you:");
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }

        public int FavoriteNumberAnswer(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            if (int.Parse(stringAnswer) <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return int.Parse(stringAnswer);
            }
            else if (int.Parse(stringAnswer) >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return int.Parse(stringAnswer);
            }
            else
            {
                return int.Parse(stringAnswer);
            }
        }
    }
}


