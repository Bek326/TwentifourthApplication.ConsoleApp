using System;
using System.IO;

namespace TwentifourthApplication.ConsoleApp
{
    class Program
    {
        static void Catalog()
        {
            string pathToDirectory = @"C:\Users\TheDarkKnight\Downloads\Students";
            DirectoryInfo dir = new DirectoryInfo(pathToDirectory);
            if(!dir.Exists)
            {
                dir.Create();
            }
            
        }
        static void WriteValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\Users\TheDarkKnight\Downloads\Students\Students.dat", FileMode.Open)))
            {
                
            }
            
        }
        static void ReadValues()
        {
            string Name;
            string Group;
            

            
            if(File.Exists(@"C:\Users\TheDarkKnight\Downloads\Students\Students.dat"))
            {
                using(BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\TheDarkKnight\Downloads\Students\Students.dat", FileMode.Open)))
                {
                    Name = reader.ReadString();
                    Group = reader.ReadString();
                    
                }
                var filePath = @"C:\Users\TheDarkKnight\Downloads\Students\Group.txt";
                
                if (File.Exists(filePath))
                {
                    File.Create(Group);
                    File.Create(Name);
                    
                }
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    
                    sw.WriteLine(Group);
                    sw.WriteLine(Name);
                    
                }
            }
        }
        public static void Main()
        {
            WriteValues();
            ReadValues();
        }
    }
}
