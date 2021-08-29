using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.IO;

namespace Project_Typing
{
    [Serializable]
    class Globals
    {
        public static int high_score = 0;
        public static void save_file()
        {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\typing_save.txt";
                File.SetAttributes(path, FileAttributes.Normal);
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(Globals.high_score.ToString());
                    fs.Write(info, 0, info.Length);
                    
                    
                }
                File.SetAttributes(path, FileAttributes.Hidden);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Save Error: "+ex.ToString());
            }
            
        }
        public static void load_file()
        {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\typing_save.txt";
                File.SetAttributes(path, FileAttributes.Normal);
                using (StreamReader sr = File.OpenText(path))
                {
                    string output = "";
                    while ((output = sr.ReadLine()) != null)
                    {
                        high_score = Int16.Parse(output);
                        Console.WriteLine(Int16.Parse(output));
                    }
                }
                File.SetAttributes(path, FileAttributes.Hidden);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Load Error: "+ex.ToString());
            }
        }
    }
}
