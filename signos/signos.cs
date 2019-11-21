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

                int anos = hoje.Year - data.Year;
                int mês = hoje.Month - data.Month;
                int dias = hoje.Day - data.Day;
                string signoo = "O seu signo é";

                if (mês <= 1)
                {
                    if (20 <=dias)
                    {
                        signoo += "";
                    }
                }

                if(mês < 0)
                {
                    mês--;
                    dias += 30;
                }
                return signoo;
            }
        }
    }
}
