using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    public class FileAccessor
    {
        StreamReader input;
        private static FileAccessor instance;

        private FileAccessor(FileStream input)
        {
            this.input = new StreamReader(input);
        }

        public static FileAccessor GetInstance()
        {
            if(instance == null)
            {
                instance = new FileAccessor(new FileStream(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "/testFile.txt", FileMode.Open));
            }
            return instance;
        }

        public string GetLineFromFile()
        {
            return input.ReadLine();
        }
    }
}
