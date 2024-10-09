using System;

namespace SimpleQuizApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the questions and answers
            string[] questions = {
                "1. What is the capital of France?",
                "2. What is 2 + 2?",
                "3. What is the largest planet in our solar system?",
                "4. Who wrote 'Romeo and Juliet'?",
                "5. What is the boiling point of water?"
            };

            string[,] options = {
                { "A. Berlin", "B. Madrid", "C. Paris", "D. Rome" },
                { "A. 3", "B. 4", "C. 5", "D. 6" },
                { "A. Earth", "B. Jupiter", "C. Saturn", "D. Mars" },
                { "A. Charles Dickens", "B. William Shakespeare", "C. Mark Twain", "D. Jane Austen" },
                { "A. 90°C", "B. 100°C", "C. 80°C", "D. 120°C" }
            };

            char[] correctAnswers = { 'C', 'B', 'B', 'B', 'B' };
            int score = 0;

            // Loop through the questions
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                for (int j = 0; j < options.GetLength(1); j++)
                {
                    Console.WriteLine(options[i, j]);
                }

                // Get user answer
                Console.Write("Your answer (A, B, C, D): ");
                char userAnswer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                // Check answer
                if (userAnswer == correctAnswers[i])
                {
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {correctAnswers[i]}.\n");
                }
            }

            // Display the final score
            Console.WriteLine($"Your final score is: {score}/{questions.Length}");
        }
    }
}
