using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_katia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pe = new Pessoa();
            Mensalidade men = new Mensalidade();

            Console.Write("Digite o nome: ");
            pe.SetNome(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            pe.SetEndereco(Console.ReadLine());
            Console.Write("Digite o CPF: ");
            pe.SetCpf(Console.ReadLine());
            Console.Write("Digite o RA: ");
            pe.SetRa(Convert.ToInt32(Console.ReadLine()));
            
            Console.Write("Digite o curso: ");
            men.SetCurso(Console.ReadLine());
            Console.Write("Digite o valor: ");
            men.SetValor(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o dia do pagamento: ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("\nDados do aluno");
            Console.WriteLine("RA: " + pe.GetRa() +"Aluno: " + pe.GetNome());
            Console.WriteLine("Endereco: "+ pe.GetEndereco() +"\n CPF: "+pe.GetCpf());
            Console.WriteLine("Curso" + men.GetCurso() + "\nValor da mensalidade: " + men.GetValor().ToString("C") +
                "\nValor a pagar: " + men.Calcular().ToString("C"));

            Console.ReadKey();
        }
    }
}
