using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    public static class Engine
    {
        public static List<Question> all = new List<Question>();
        public static List<Question> selected = new List<Question>();
        public static List<Question> questions = new List<Question>();
        public static Random rnd = new Random();
        
        public static void getAllQuestions() 
        {
            string[] files = Directory.GetFiles(@"../../Intrebari");
            foreach (string s in files)
                all.Add(new Question(s));

        }

        public static int punctaj_total;
    }
}
