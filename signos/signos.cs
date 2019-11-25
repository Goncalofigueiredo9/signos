using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signos
{
    class signos
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string diadasemana
        {
            get
            {
                return data.ToString("dddddd");
            }
        }

        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;
                
                int anos = hoje.Year - data.Year;
                int mês = hoje.Month - data.Month;

                if (mês < 0)
                {
                    anos--;
                    mês += 12;
                }

                int dias = hoje.Day - data.Day;
                if (mês < 0)
                {

                    mês--;
                    dias += 30;
                }

                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos ";
                frase += mês.ToString() + " meses ";
                frase += dias.ToString() + " dias ";

                return frase;
            }
        }

        public string signo
        {
            get
            {
                DateTime hoje = DateTime.Now;

                int jan = 1;
                int fev = 2;
                int mar = 3;
                int abr = 4;
                int mai = 5;
                int jun = 6;
                int jul = 7;
                int ago = 8;
                int set = 9;
                int otu = 10;
                int nov = 11;
                int dez = 12;

                int dias = data.Day;

                string signo = "O seu signo é ";

                if (jan == data.Month)
                {
                    if (19 < dias)
                    {

                        signo += "Aquário.";
                    }
                    else
                    {
                        signo += "Capricórnio.";
                    }
                }
                else if (fev == data.Month)
                {
                    if (18 < dias)
                    {
                        signo += "Peixes.";
                    }
                    else
                    {
                        signo += "Aquário.";
                    }
                }
                else if (mar == data.Month)
                {
                    if (20 < dias)
                    {
                        signo += "Áries.";
                    }
                    else
                    {
                        signo += "Peixes.";
                    }
                }
                else if (abr == data.Month)
                {
                    if (19 < dias)
                    {
                        signo += "Touro.";
                    }
                    else
                    {
                        signo += "Áries.";
                    }
                }
                else if (mai == data.Month)
                {
                    if (20 < dias)
                    {
                        signo += "Gémeos.";
                    }
                    else
                    {
                        signo += "Touro.";
                    }
                }
                else if (jun == data.Month)
                {
                    if (20 < dias)
                    {
                        signo += "Carangueijo.";
                    }
                    else
                    {
                        signo += "Gémeos.";
                    }
                }
                else if (jul == data.Month)
                {
                    if (22 < dias)
                    {
                        signo += "Leão.";
                    }
                    else
                    {
                        signo += "Carangueijo.";
                    }
                }
                else if (ago == data.Month)
                {
                    if (22 < dias)
                    {
                        signo += "Virgem.";
                    }
                    else
                    {
                        signo += "Leão.";
                    }
                }
                else if (set == data.Month)
                {
                    if (22 < dias)
                    {
                        signo += "Libra.";
                    }
                    else
                    {
                        signo += "Virgem.";
                    }
                }
                else if (otu == data.Month)
                {
                    if (22 < dias)
                    {
                        signo += "Escorpião.";
                    }
                    else
                    {
                        signo += "Libra.";
                    }
                }
                else if (nov == data.Month)
                {
                    if (21 < dias)
                    {
                        signo += "Sagitário.";
                    }
                    else
                    {
                        signo += "Escorpião.";
                    }
                }
                else if (dez == data.Month)
                {
                    if (21 < dias)
                    {
                        signo += "Capricórnio.";
                    }
                    else
                    {
                        signo += "Sagitário.";
                    }
                }
                return signo;
            }
        }
    }
}
