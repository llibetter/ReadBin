using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\lli\Documents\WeChat Files\dkddff\FileStorage\File\2019-09\BuildvectorGrid.b";
            FileStream myStream = new FileStream(path, FileMode.Open, FileAccess.Read);//读取数据
            BinaryReader myReader = new BinaryReader(myStream);
            int ID = 0;
            while(myReader.BaseStream.Position < myReader.BaseStream.Length && ID<100)
            //while (myReader.PeekChar() != -1)
            {
              
                string d = Convert.ToString(myReader.ReadInt32());
                Console.WriteLine($"{ID++}\t {d}");
            }
            myReader.Close();
            myStream.Close();

        }
    }
}
