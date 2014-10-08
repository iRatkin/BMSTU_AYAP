using System;
using System.IO;
using System.Collections.Generic;

namespace sem_ayap_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//а. составить список всех файлов в директории и поддиректории "Имя файла - путь"
			//б. по запросу "Имя файла" за О(1) выдавать путь
			var Path = "/Users/Ivan/Downloads";
			var dir = new DirectoryInfo(Path);  
			var files = new List<string, string>(); 

			foreach (FileInfo file in dir.GetFiles())  
			{ 
				files.Add(file.FullName, file.Name); 
			}

			Console.WriteLine(files[1, 1]);

			
		}
	}
}
