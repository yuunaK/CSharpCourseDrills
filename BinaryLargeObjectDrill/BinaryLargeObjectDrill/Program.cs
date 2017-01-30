// There are two things that we work with: assemblies and namespaces.
// There are two actions we have to do: Use Reference Manager to add
// a reference to an assembly.  Second, you have to import namespaces
// with the keyword "using".

// Before invoking namespaces, you must go to Solution Explorer
// right-click on the References folder and select Add Reference.
// This will allow you to reference the desired assemblies you 
// may need in your program.

// It is only after you reference an assembly that you can invoke 
// namespaces in the assembly with the keyword "using".

// Below is a listing of namespaces and their associated
// assemblies used in the program.


using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program Overview
// This program displays the use of two types of programming
// constructs: Streams and Readers/Writers.
// Two stream classes are used in this program: the FileStream
// and the MemoryStream.
// In addition, the BinaryReader and BinaryWriter Classes are 
// also implemented.

// The overall logic for the program is to
// 1. take an image file in jpg format located on the local device
// 2. convert it to a byte array,
// 3. take data in the byte array and write it to a text file, 
// 4. take the data in the text file and convert it to a byte array
// 5. convert data in byte array to re-create a jpg image format file.



namespace BinaryLargeObjectDrill
{
    class Program
    {
        public class StreamingAndRetrievingBlob
        {

            //This method will go to specified image and create a FileStream Object.  
            //Use FileStream object to copy image into a byte array and move it into the Stream.
            //In order to stream the file, we have to put it into a byte array.
            public static byte[] ImageToByteArray(string imagePath)
            {

                //Create a FileStream object, fs.  The three arguments are
                // 1. the filepath to the image passed as a string;
                // 2. FileMode is set to Open - open the file at location provided
                // 3. FileAccess is set to read - read the contents of file.
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                // 4. Create a byte array. Use the length of the filestream object 
                // to specify length of byte array.
                byte[] b = new byte[fs.Length];
                // 5. Use the FileStream method READ to read the filestream object and 
                // copy to the byte array.
                fs.Read(b, 0, (int)fs.Length);
                // 6. When finished copying the filestream object to byte array, close
                // the filestream object.
                fs.Close();
                // return the byte array.
                return b;
            }



            //This method will take the byte array which has the image data
            //and print it to a text file.
            //We are doing two things in this method: we are accomplishing the
            //of putting teh ByteArray into a text file and verifying if we have
            //actually accomplished our task by checking the lengths of the two
            //arrays.
            //To note: We could in theory check the elements in the two arrays to
            //make sure that the elements in the two arrays are also the equal.
            //This method accomplishes two tasks: Write Byte Array to text file 
            //and verifying that we have done this task.
            
            public static void PutByteArrayIntoTextFile(byte[] byteArray)
            {
                int byteArrayLength = byteArray.Length;
                byte[] verifyArray = new byte[byteArrayLength];
                string filepath = "C:\\Users\\yk123\\documents\\visual studio 2015\\Projects\\BinaryLargeObjectDrill\\TextFileToReceiveBlob.txt";


                using (BinaryWriter binWriter = new BinaryWriter(new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite)))
                {
                    Console.WriteLine("Writing the data. ");
                    binWriter.Write(byteArray, 0, byteArrayLength);


                    using (BinaryReader binReader = new BinaryReader(binWriter.BaseStream))
                    {
                        binReader.BaseStream.Position = 0;
                        if (binReader.Read(verifyArray, 0, byteArrayLength) != byteArrayLength)
                        {
                            Console.WriteLine("Error writing the data.");
                            return;
                        }
                    }
                }
            }

            // This method replicates our first method: namely if we want to take static data and move 
            //it into the stream so that it can be moved, we have to put it into a byte array.
            public static byte[] FromTextFileBacktoStream()
            {
                string locationOfTextFile = "C:\\Users\\yk123\\documents\\visual studio 2015\\Projects\\BinaryLargeObjectDrill\\TextFileToReceiveBlob.txt";
                FileStream fs2 = new FileStream(locationOfTextFile, FileMode.Open, FileAccess.Read);
                byte[] tf = new byte[fs2.Length];
                fs2.Read(tf, 0, (int)fs2.Length);
                fs2.Close();
                return tf;
            }

            //With this method, we can convert the byte array in the text file
            //back into an image.
            //We create a file path to where we want the image to be stored.
            //We use the Image class which is in System.Drawing and ImageFormat
            //which is in System.Drawing.Imaging to get these tasks done.

            //Note: Before using these classes, I had to first use the Reference
            //Manager to add the System.Drawing assembly.
            //To acces the Reference Manager, select Solution Explorer from the
            //View tab.  Right click on Reference folder to see popup menu.
            //Select Add Reference option. This will bring up the Reference
            //Manager window. Scroll down to view all available assemblies.
            //Once you have added references to desired assemblies, you can 
            //invoke namespaces in the assemblies with the keyword 'using'.

            

            public static void FromStreamBackToImage(byte[] ba)
            {
                string filepath2 = "C:\\Users\\yk123\\Pictures\\lady-orchid-peony.jpg";
                //Pass the byte array into a MemoryStream object. Use keyword 'new'.
                //Create an Image object and use the FromStream method to draw data 
                //from the MemoryStream.
                using (Image image = Image.FromStream(new MemoryStream(ba)))
                {
                    //Using the Save Method, use the ImageFormat method from
                    //System.Drawing.Imaging to convert data in byte array to
                    //jpeg format and save it to location specified in filepath2.
                    image.Save(filepath2, ImageFormat.Jpeg);
                }

            }
            // This part of the program can be made to take user input.
            // They can provide filepath to image and filepath to a
            // blank text file.  For this assignment, I am using 
            // image file and text file on my device.
            static void Main(string[] args)
            {
                
                PutByteArrayIntoTextFile(ImageToByteArray("C:\\Users\\yk123\\Pictures\\lady-orchid-peony-0410.jpg"));
                FromStreamBackToImage(FromTextFileBacktoStream());
                System.Console.ReadKey(true);
            }
        }
    }
}





