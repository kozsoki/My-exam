using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Licenta
{
    public class Question
    {

        public string Domeniu;
        public int nivel;
        public string Titlu;
        public List<string> continut;
        public string Hint;
        public List<string> raspunsuri;
        public int idrc;
        public string image;
        public int punctaj;
        public int timp;
        public string name;

        public Question(string path)
        {
            
            continut = new List<string>();
            raspunsuri = new List<string>();

            TextReader dataLoad = new StreamReader(path);
            Domeniu = dataLoad.ReadLine ().Split (':')[1].Trim();
            nivel = int.Parse(dataLoad.ReadLine().Split(':')[1]);
            Titlu = dataLoad.ReadLine().Split(':')[1];

            string tmp;
            while ((tmp = dataLoad.ReadLine())!= "endl")
            {
                continut.Add(tmp.Split (':')[1]);
            }
            Hint = dataLoad.ReadLine().Split(':')[1];
            while ((tmp = dataLoad.ReadLine()) != "endl")
            {
                raspunsuri.Add(tmp.Split(':')[1]);
            }
            idrc = int.Parse(dataLoad.ReadLine().Split(':')[1]);
            image = dataLoad.ReadLine().Split(':')[1];
            punctaj = int.Parse(dataLoad.ReadLine().Split(':')[1]);
            timp = int.Parse(dataLoad.ReadLine().Split(':')[1]);
            

            string []tmp1 =  path.Split('\\');
            name = tmp1[tmp1.Length-1];
        }

        public string shortData()
        {
            return name + "(" + Domeniu + ")";
        }
    }
}
