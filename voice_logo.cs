using System;
using System.Drawing;
using System.IO;
using System.Media;

namespace AI_Chatbott
{//start of namespace
    public class voice_logo

         {//start of class
        private string full_path = AppDomain.CurrentDomain.BaseDirectory;


        public voice_logo()
        {//start of constructor

            AsciLogo();
            greetingsAudio();



        }//end of constructor


    private void greetingsAudio()
    {//start of method GREETINGS METHOD 



        //check if the path is auto collected 
        Console.WriteLine(full_path);



        //then replace the \bin\Debug 
        string correct_path = Path.Combine(full_path, "greet.wav");
        // string correct_path = full_path.Replace(@"\bin\Debug\netX.X\", @"\greet.wav");



        //check if audio found 
        Console.WriteLine(correct_path);



        //use the soundPlay class to play the audio 
        //creating an instance for the soundPlay class 
        //with an object name greet 
        SoundPlayer greet = new SoundPlayer(correct_path);




        //then play the sound using the play method 
        //This line plays the audio file
        //line five
        greet.PlaySync();


        //Console.ReadLine();



    }//end of greetings method




    private void AsciLogo()//ASCI METHOD 

    {//start of asci meth

        //path of the logo [ where the logo is ] 

        //string path = string.Empty;
        //string path = full_path.Replace(@"\bin\Debug\" ,@"\logo.jpg"); 
        string path = Path.Combine(full_path, "logos.jpg");



        Bitmap image = new Bitmap(path);



        // Resize for better console fit 

        int width = 150;

        int height = 70; //(image.Height * width) / image.Width; 

        Bitmap resized = new Bitmap(image, new Size(width, height));



        // Default color , you can set yours before this line 

        string asciiChars = "@#S%?*+;:,. ";



        //start by the height 

        for (int y = 0; y < resized.Height; y++)

        {

            //then width 

            for (int x = 0; x < resized.Width; x++)

            {

                //color the pixel on x and y 

                Color pixel = resized.GetPixel(x, y);



                // Convert to grayscale 

                int gray = (pixel.R + pixel.G + pixel.B) / 3;



                // Map grayscale to ASCII 

                int index = (gray * (asciiChars.Length - 1)) / 255;



                Console.Write(asciiChars[index]);

            }


            Console.WriteLine();

        }

    }//end of asci meth

}//end of class
}//end of namespace