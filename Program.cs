using System;
using System.Collections.Generic;

namespace GetDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are there?");
            string userCountResponse = Console.ReadLine();

            int userCount = int.Parse(userCountResponse);

            List<Person> users = new List<Person>();
            for (int i = 0; i < userCount; i++)
            {
                Person user = new Person();

                user.Name = user.AnswerQuestion("What is your name?");
                user.FavoriteNumber = user.FavoriteNumberAnswer("What is your favorite number?");
                user.NumberOfKids = user.AnswerQuestionWithInteger("How many kids do you have?");
                user.FavoriteAnimal = user.AnswerQuestion("What is your favorite animal?");

                users.Add(user);

            }
            Console.Clear();
            foreach (Person user in users)
            {
                Console.WriteLine($"{user.Name}'s favorite number is {user.FavoriteNumber}, " +
                	$"his/her favorite animal is {user.FavoriteAnimal} and he/she have {user.NumberOfKids} kid(s).");

            }

        }
    }
}
