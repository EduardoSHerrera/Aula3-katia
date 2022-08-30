using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_katia
{
    internal class Mensalidade
    {
        string curso;
        double valor;
        int dia;

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }
        public string GetCurso()
        {
            return this.curso;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetDia(int dia)
        {
            this.dia = dia;
        }
        public int GetDia()
        {
            return this.dia;
        }
        
        public double Calcular()
        {
            if(this.dia <= 5)
            {
                return this.valor * 0.95;
            }
            else
            {
                if(this.dia > 10)
                {
                    return this.valor * 1.02;
                }
                else
                {
                    return this.valor;
                }
            }
        }
    }
}
