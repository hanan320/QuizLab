namespace QuizLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t \t \t Welcome to QuizMaster!\nThis quiz will test your knowledge of IT fundamentals and consists of 10 questions. Prepare yourself and let's begin!");
            Console.WriteLine("Before we start, please ensure that you respond with A/a, B/b, C/c, or D/d for each answer. You will have 20 seconds to answer each question.\n\n");

            try
            {
                StartQuiz.quiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
