using System;
using System.IO;
using System.Text;

namespace FileSystemExample
{
    public class FSExample
    {
        public static void DrivesDemo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                Console.WriteLine($"Is Ready: {drive.IsReady}");
            }
        }

        public static void EnvironmentDemo()
        {
            Console.WriteLine($"OSVersion: {Environment.OSVersion}");
            Console.WriteLine($"Version: {Environment.Version}");
        }

        public static void DirectoryDemo()
        {
            //string path = "D:\\User\\Source\\NewDir";
            string path = @"D:\User\Source\NewDir";
            Directory.CreateDirectory(path);
            Console.WriteLine($"The directory was created successfully at {Directory.GetCreationTime(path)}");
        }

        public static void DirectoryInfoDemo()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\User\Source\NewDirInfo");
            // Пытаемся создать директорию
            di.Create();
            Console.WriteLine("The directory was created successfully");
            // Удаляем ее
            di.Delete();
            Console.WriteLine("The directory was deleted successfully");
        }

        public static void FileDemo()
        {
            string path = @"D:\User\Source\NewDir\file.txt";

            if (!File.Exists(path))
            {
                // Создаем файл для записи
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello there");
                }
            }
        }

        public static void FileInfoDemo()
        {
            string path = @"D:\User\Source\NewDir\fileinfo.txt";
            var fileInfo = new FileInfo(path);

            // Создаем файл для записи
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Hello there");
            }
        }

        public static void FileStreamDemo()
        {
            string path = @"D:\User\Source\NewDir\file2.txt";
            string text = "Some text to write";

            //Создаем файл с использование FileStream
            using (FileStream fileStream = File.Create(path))
            {
                fileStream.Write(new UTF8Encoding().GetBytes(text), 0, text.Length);
            }

            //Открываем FileStream для чтения из файла
            using (FileStream fileStream = File.OpenRead(path))
            {
                var buffer = new byte[1024];
                var encoding = new UTF8Encoding();
                while (fileStream.Read(buffer, 0, buffer.Length) > 0)
                {
                    Console.WriteLine(encoding.GetString(buffer));
                }
            }
        }

        public static void StreamReaderDemo()
        {
            string path = @"D:\User\Source\NewDir\file.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void StreamWriterDemo()
        {
            string path = @"D:\User\Source\NewDir\file.txt";
            //Получаем директории, расположенны на диске D:
            DirectoryInfo[] dDirs = new DirectoryInfo(@"D:\").GetDirectories();

            //Запишем полученные имена в файл
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (DirectoryInfo dir in dDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }
        }

        public static void BinaryWriterDemo()
        {
            string path = @"D:\User\Source\NewDir\file.txt";

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"c:\Temp");
                writer.Write(10);
                writer.Write(true);
            }
        }

        public static void BinaryReaderDemo()
        {
            string path = @"D:\User\Source\NewDir\file.txt";

            if (File.Exists(path))
            {
                float aspectRatio;
                string tempDirectory;
                int autoSaveTime;
                bool showStatusBar;

                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }

        public static void FileStreamExample()
        {
            FileStream stream = new FileStream(
                @"D:\User\Source\NewDir\file.txt", 
                FileMode.OpenOrCreate, 
                FileAccess.ReadWrite, 
                FileShare.Read);

            StreamReader reader = new StreamReader(stream);

            StreamWriter writer = new StreamWriter(stream);

            stream.Flush();
            stream.Dispose();

        }
    }
}
