using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class ReshenieZadachi
    {
        
        private List<Nakladnaia> nakladnaia;
        public string Responce; 
        public string ResponceSumm; 
        public ReshenieZadachi()
        {
            
            nakladnaia = new List<Nakladnaia> 
            {
                new Nakladnaia{Data = "11/03/2002", Name = "FirstNakl", Summa = 2000},
                new Nakladnaia{Data = "11/03/2002", Name = "SirstNakl", Summa = 2000},
                new Nakladnaia{Data = "12/01/2002", Name = "SecondNakl", Summa = 3000},
                new Nakladnaia{Data = "13/02/2002", Name = "ThrehdNakl", Summa = 4000},
                new Nakladnaia{Data = "14/03/2002", Name = "FourNakl", Summa = 5000},
                new Nakladnaia{Data = "15/05/2002", Name = "FivetNakl", Summa = 4000}
            };
        }
        public string OutPut()
        {
            string Out = "";
            foreach (var i in nakladnaia)
                Out += i.Name + " " + i.Summa + " " + i.Data + " " + Environment.NewLine;
            return Out;
        }
        public void DeleteNakladnaya(string data)
        {
            for (int i = 0; i < nakladnaia.Count; i++)
            {
                nakladnaia?.Remove(nakladnaia.FirstOrDefault(x => x.Data == data));
            }
            Responce = OutPut();
        }
        public void OutPutSumm(int summ)
        {
            string Out = "";
            foreach (var i in nakladnaia)
            {
                if (i.Summa == summ)
                {
                    Out += i.Name + " " + i.Summa + " " + i.Data + "" + Environment.NewLine;
                }
            }
           ResponceSumm = Out;

        }
    }
}
