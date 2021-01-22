using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FileManager
    { 
        public string LoadFileText(string path)
        {
            FileStream FileStream = new FileStream(path, FileMode.Open);
            StreamReader streamReader = new StreamReader(FileStream);
            string text = streamReader.ReadToEnd();
            FileStream.Close();
            return text;
        }
        public void SaveTextToFile(string path,string text)
        {
            FileStream FileStream = new FileStream(path, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(FileStream);
            streamWriter.Write(text);
            streamWriter.Close();
            FileStream.Close();
        }
    }
}
