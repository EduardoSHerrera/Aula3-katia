
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_katia
{
    internal class Pessoa
    {
        string nome;
        string cpf;
        string endereco;
        int ra;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string GetEndereco()
        {
            return this.endereco;
        }
        public void SetRa(int ra)
        {
            this.ra = ra;
        }
        public int GetRa()
        {
            return this.ra;
        }
    }
}
