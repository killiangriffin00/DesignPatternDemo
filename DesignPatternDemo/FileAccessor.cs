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
        
        public FileAccessor(FileStream input)
        {
            this.input = new StreamReader(input);
        }

        public string GetLineFromFile()
        {
            return input.ReadLine();
        }
    }
}
