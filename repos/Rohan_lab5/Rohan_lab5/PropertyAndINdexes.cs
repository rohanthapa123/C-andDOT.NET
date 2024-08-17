using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab5
{
    internal class PropertyAndIndexes
    {
        string[] subject = new string[5];
        public string this[int index]
        {

            get
            {
                return subject[index];
            }

            set
            {
                subject[index] = value;
            }
        }

        
    }
    public class QuestionThree
    {
        public static void Main(string[] args)
        {
            PropertyAndIndexes p1 = new PropertyAndIndexes();
            p1[0] = "MIS";
            p1[1] = "Computer Graphics";
            p1[2] = "Computer Network";
            p1[3] = "Introduction To Management";
            p1[4] = "DN.";

            for(int i = 0;i < 5;i++)
            {
                Console.WriteLine(p1[i]);
            }
            Console.ReadKey();

        }
    
    }
}
