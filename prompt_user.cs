using System;
using System.Xml.Linq;

namespace AI_Chatbott
{//start of namespace
    public class prompt_user
    {//start of class

        //global variable declaration, string datatype
        //and variable name called name
        //must be private
        private string name = string.Empty;


        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("◢======================~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~========================◣");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                      /// Welcome to CYBERSECURITY chatbot ///          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("◥======================~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~========================◤");
            Console.ResetColor();
        }


        //void method to prompt the user for name
        //method called asking_for_name()
        public void Asking_For_Username()
        { //start of asking name method

            //ask for name

            //Chatbot and colors

            //chatbot name and color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("chatBot : ");

            //Chat asking for name message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please enter your name...");

            //reset color
            Console.ResetColor();

            //do while to check and re-prompt the user
            do
            { //start of do while 

                //user entering name
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("user : ");

                //input color
                Console.ForegroundColor = ConsoleColor.Gray;

                name = Console.ReadLine();

                //reset color
                Console.ResetColor();


            } while (!check_name());//end of do while


        }//end of the asking name method

        //boolean method to check if the user entered name
        //method name check_name()
        private Boolean check_name()
        { //start of check_name


            //check if the name is entered using if statement
            if (name == "")
            { //start if statement

                //show error message
                //Chatbot name and colour
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot : ");

                //Chatbot message if name not entered
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please try to enter your name..");

                //reset color
                Console.ResetColor();

                //return false
                return false;
            }//end of if statement
            else
            {//start of else

                //return the success message
                //Chatbot name and colour
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot :");

                //AI message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Hey ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" " + name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" how can i help you, You can ask about  purpose, passwords, phishing, safebrowsing..");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type exit to end the conversation..");

                //reset color
                Console.ResetColor();
                //return
                return true;



            }//end of else




        }//end of check_name method


        //method to return the user name
        public string return_name()
        {//start of rn method
            //returing the name of the user
            return name;
        }//end of rn method
    }//end of class
}//end of namespace