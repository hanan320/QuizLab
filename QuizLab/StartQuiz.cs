using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLab
{
    internal class StartQuiz
    {
        public static void quiz()
        {
            string[] questions =
         {
            "Which of the following is considered an input device?\r\r\nA) Monitor\r\nB) Printer\r\nC) Keyboard\r\nD) Speaker",
            "Which of the following is not an example of an operating system?\r\nA) Windows\r\nB) Linux\r\nC) Microsoft Office\r\nD) macOS",
            "Which of the following is a non-volatile storage device?\r\nA) RAM\r\nB) SSD\r\nC) Cache memory\r\nD) Register",
            "What does CPU stand for?\r\nA) Central Processing Unit \r\n B) Computer Processing Unit\r\nC) Central Power Unit\r\nD) Computer Power Unit\r\n",
            "What is the primary function of a GPU in a computer?\r\nA) Processing input/output operations\r\nB) Handling network communication\r\nC) Rendering graphics\r\nD) Managing storage operations \r\n",
            "Which type of network connects devices within a limited area, like a home, office, or school?\r\nA) LAN (Local Area Network)\r\nB) WAN (Wide Area Network)\r\nC) MAN (Metropolitan Area Network)\r\nD) PAN (Personal Area Network)\r\n",
            "What protocol is commonly used for sending and receiving emails?\r\nA) FTP (File Transfer Protocol)\r\nB) SMTP (Simple Mail Transfer Protocol)\r\nC) HTTP (Hypertext Transfer Protocol)\r\nD) UDP (User Datagram Protocol)\r\n",
            "What does HTML stand for?\r\nA) Hyper Transfer Markup Language\r\nB) Hyperlink Text Markup Language\r\nC) Hypertext Markup Language\r\nD) Hyper Text Manipulation Language\r\n",
            "What is the purpose of a firewall in network security?\r\n A) To filter and control network traffic\r\nB) To boost internet speed\r\nC) To manage file storage\r\nD) To encrypt data transmissions\r\n",
            "Which programming language is commonly used for developing web applications?\r\n A) Java\r\nB) C++\r\nC) Python\r\nD) JavaScript\r\n"
        };

            string[] answers =
            {
            "C",
            "C",
            "B",
            "A",
            "C",
            "A",
            "B",
            "C",
            "A",
            "D"
        };

            int trackScore = 0;


            int timeLimitPerQuestion = 20000;

            for (int i = 0; i < questions.Length; i++)
            {

                Stopwatch stopwatch = Stopwatch.StartNew();
                Console.WriteLine("\n");
                Console.WriteLine(questions[i]);

                string answer = "";
                try
                {
                    answer = ValidatedAnswer.getValidatedAnswer();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }


                stopwatch.Stop();
                if (stopwatch.ElapsedMilliseconds >= timeLimitPerQuestion)
                {
                    Console.WriteLine("Time's up! Moving to the next question. \n");
                    continue;
                }

                if (answer == answers[i])
                {
                    Console.WriteLine("Correct Answer Good Job! *_* \n");
                    trackScore++;

                }
                else
                {
                    Console.WriteLine($"Wrong T_T ! The correct answer was: {answers[i]} \n ");
                }

            }

            if (trackScore >= 0 && trackScore <= 10)
            {
                if (trackScore == 10)
                {

                    Console.WriteLine("Congratulations! You scored full marks  10 out of 10 !\n ");
                }
                else if (trackScore >= 5)
                {
                    Console.WriteLine($"Congratulations! You passed with a score of {trackScore} out of 10 \n");
                }
                else
                {
                    Console.WriteLine($"Sorry, you failed with a score of {trackScore} out of 10 \n");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid score detected\n");
            }





        }

}
}
