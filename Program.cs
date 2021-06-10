using System;
using System.IO;
using Aspose.Zip;

namespace JapaKerbalExtractor { 
    class Program {
        static void Main(string[] args) {
            DirectoryInfo base_dir = new DirectoryInfo(System.AppContext.BaseDirectory);
            Console.Title = "Japa4551's Kerbal Extractor v1 - Yes the code intentionally has 69 lines";

            if(Directory.Exists("Output")) {
                DateTime current_time = DateTime.Now;
                Console.WriteLine("A previously generated GameData folder was found! Renaming it...\n");
                Directory.Move("Output", $"./Output_{current_time.Hour}-{current_time.Minute}-{current_time.Second}");
            }

            Console.Write("Please specify the extension of the compressed file(s) (without the .): ");

            string file_extension = Console.ReadLine();

            if(base_dir.GetFiles($"*.{file_extension}").Length < 1 || file_extension.Length == 0) {
                Console.WriteLine("Silly! There are no files with that extension!");
                Console.ReadLine(); 
                Environment.Exit(0);
            }

            Console.Write($"\nFiles with extension {file_extension} in the current Executable's folder: ");
            Console.WriteLine(base_dir.GetFiles($"*.{file_extension}").Length);

            Console.WriteLine("Press Enter to extract the files...");
            Console.ReadLine();

            for(int index = 0; index < base_dir.GetFiles($"*.{file_extension}").Length; index++) {
                FileInfo[] file_array = base_dir.GetFiles($"*.{file_extension}");

                string current_file_name = Path.GetFileName(Convert.ToString(file_array[index]));

                Console.Write($"Extracting {current_file_name}... ");

                try {
                    using (var archive = new Archive(current_file_name)) archive.ExtractToDirectory("Output");
                    
                    Console.WriteLine("Ok!\n");
                }

                catch(Exception e) { 
                    Console.WriteLine(e + "\n");
                }
            }

            if(Directory.Exists("Output/GameData")) {
                Console.WriteLine("GameData folder found! moving files and deleting GameData...");

                foreach(string file in Directory.GetFiles("Output/GameData/")) 
                { File.Move(file, $"Output/{Path.GetFileName(file)}"); }

                foreach(string directory in Directory.GetDirectories("Output/GameData/")) 
                { Directory.Move(directory, $"Output/{Path.GetFileName(directory)}"); }

                Directory.Delete("Output/GameData");
            }

            Console.WriteLine("\nOk! You can close the program now! (Press Enter)"); 
            Console.WriteLine("Don't forget to check the Output folder for extra files!");
            Console.ReadLine();
        }
    }
}