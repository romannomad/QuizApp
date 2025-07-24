
class QuizProgram
{
    static void Main()
    {
        //Create questions

        string[] questions =
        {
            "What is the fastest selling book?",
            "What was Quenn Elizabeth age when she was crowned?",
            "Which blood type is a universal donor?"
        };

        //Create answers

        string[] answers =
        {
            "A. Hunger Games \nB. Harry Potter \nC. Bible",
            "A. 27 \nB. 24 \nC. 31",
            "A. O- \nB. B+ \nC. AB"
        };

        int[] correctAnswers = { 1, 1, 0};
        int playerScore = 0;

        Console.WriteLine("Welcome to the Quiz App");
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("Question " + (i + 1));
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Please enter your answer ('A', 'B', or 'C'): ");
            string playerAnswer = Console.ReadLine();

            //Validate Answers
            if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                playerScore++;
            }
        }

        //Print score out to user
        Console.WriteLine("Quiz completed!");
        Console.WriteLine("Your score is: " + playerScore + "/" + questions.Length);
    }

}