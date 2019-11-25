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

        public string signofrases
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

                string signofrase = "";

                if (jan == data.Month)
                {
                    if (19 < dias)
                    {

                        signofrase += "Algumas coisas na vida nos aquarianos podem se realizar em ritmo mais lento do que você está acostumado";
                    }
                    else
                    {
                        signofrase += "Diversas áreas da vida do capricorniano, de valores materiais e espirituais, podem passar por mudanças em 2020.";
                    }
                }
                else if (fev == data.Month)
                {
                    if (18 < dias)
                    {
                        signofrase += "Pequenos detalhes podem oportunizar importantes mudanças positivas na vida dos piscianos.";
                    }
                    else
                    {
                        signofrase += "Algumas coisas na vida nos aquarianos podem se realizar em ritmo mais lento do que você está acostumado.";
                    }
                }
                else if (mar == data.Month)
                {
                    if (20 < dias)
                    {
                        signofrase += "Os arianos terão um ano com forte tendência de crescimento e expansão na carreira e na profissão.";
                    }
                    else
                    {
                        signofrase += "Pequenos detalhes podem oportunizar importantes mudanças positivas na vida dos piscianos.";
                    }
                }
                else if (abr == data.Month)
                {
                    if (19 < dias)
                    {
                        signofrase += "Os taurinos terão um ótimo ano para realizar mudanças na forma de ser e de se relacionar..";
                    }
                    else
                    {
                        signofrase += "Os arianos terão um ano com forte tendência de crescimento e expansão na carreira e na profissão.";
                    }
                }
                else if (mai == data.Month)
                {
                    if (20 < dias)
                    {
                        signofrase += "Os geminianos podem perceber com mais força o movimento de Mercúrio Retrógrado no novo ano.";
                    }
                    else
                    {
                        signofrase += "Os taurinos terão um ótimo ano para realizar mudanças na forma de ser e de se relacionar..";
                    }
                }
                else if (jun == data.Month)
                {
                    if (20 < dias)
                    {
                        signofrase += "Os cancerianos terão um ano excelente para correr atrás do que você tanto almejam, porém, nada virá facilmente..";
                    }
                    else
                    {
                        signofrase += "Os geminianos podem perceber com mais força o movimento de Mercúrio Retrógrado no novo ano.";
                    }
                }
                else if (jul == data.Month)
                {
                    if (22 < dias)
                    {
                        signofrase += "Leoninos terão a oportunidade de fazer importantes mudanças durante o novo ano. Porém, atenção ao estresse.";
                    }
                    else
                    {
                        signofrase += "Os cancerianos terão um ano excelente para correr atrás do que você tanto almejam, porém, nada virá facilmente..";
                    }
                }
                else if (ago == data.Month)
                {
                    if (22 < dias)
                    {
                        signofrase += "Virginianos, abracem as oportunidades porque poderão revelar talentos da sua personalidade que até então você nem sabia que tinha.";
                    }
                    else
                    {
                        signofrase += "Leoninos terão a oportunidade de fazer importantes mudanças durante o novo ano. Porém, atenção ao estresse.";
                    }
                }
                else if (set == data.Month)
                {
                    if (22 < dias)
                    {
                        signofrase += "Librianos têm alto potencial para crescimento profissional, mas com certo nível de tensão e estresse nos relacionamentos.";
                    }
                    else
                    {
                        signofrase += "Virginianos, abracem as oportunidades porque poderão revelar talentos da sua personalidade que até então você nem sabia que tinha.";
                    }
                }
                else if (otu == data.Month)
                {
                    if (22 < dias)
                    {
                        signofrase += "O novo ano pode ser especialmente difícil para os escorpianos, que poderão perceber mais diretamente a retrogradação de Mercúrio.";
                    }
                    else
                    {
                        signofrase += "Librianos têm alto potencial para crescimento profissional, mas com certo nível de tensão e estresse nos relacionamentos.";
                    }
                }
                else if (nov == data.Month)
                {
                    if (21 < dias)
                    {
                        signofrase += "Está na hora de transformar seus sonhos em realidade, sagitariano! 2020 pode ser um bom ano para criar novas rotinas e dar início a novos projetos.";
                    }
                    else
                    {
                        signofrase += "O novo ano pode ser especialmente difícil para os escorpianos, que poderão perceber mais diretamente a retrogradação de Mercúrio.";
                    }
                }
                else if (dez == data.Month)
                {
                    if (21 < dias)
                    {
                        signofrase += "Diversas áreas da vida do capricorniano, de valores materiais e espirituais, podem passar por mudanças em 2020.";
                    }
                    else
                    {
                        signofrase += "Está na hora de transformar seus sonhos em realidade, sagitariano! 2020 pode ser um bom ano para criar novas rotinas e dar início a novos projetos.";
                    }
                }
                return signofrase;
            }
        }
    }
}
