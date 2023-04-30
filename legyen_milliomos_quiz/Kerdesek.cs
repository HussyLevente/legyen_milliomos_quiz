using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyen_milliomos_quiz
{
    internal class Kerdesek
    {
        public string Kerdes;
        public string A;
        public string B;
        public string C;
        public string D;
        public string Valasz;
        public Kerdesek(string sor)
        {
            var db = sor.Split(";");
            this.Kerdes = db[0];
            this.A = db[1];
            this.B = db[2];
            this.C = db[3];
            this.D = db[4];
            this.Valasz = db[5];
        }
    }
}
