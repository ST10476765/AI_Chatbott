using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Chatbott
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            new voice_logo() { };

            //creating an instance for the class prompt_user 
            //with an object name collect_name
            prompt_user collect_name = new prompt_user();

            //call the welcome and Asking_For_Username method from the prompt_user class
            collect_name.WelcomeMessage();
            collect_name.Asking_For_Username();
            //get the returned name of the user
            string name = collect_name.return_name();


            //user and chatbot chat 
            //instance for the class ai_response
            //with an object name chatting chatting
            chats chatting = new chats();
            //now start the start the chatting
            chatting.chatbot_chats(name);


        }//end of main method
    }//end of class
}//end of namespace
