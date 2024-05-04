using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bissexto
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;

        public Pessoa(string nome, int idade, string profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public string GetProfissao()
        {
            return profissao;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public void SetProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        public int GetIdadeEmBissexto()
        {
       
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = anoAtual - idade;
            int idadeBissexto = 0;
            
            // Vai percorrer desde o ano de nascimento até o ano atual
            for(int ano = anoNascimento; ano <= anoAtual; ano++)
            {
                // Metodo da classe DateTime que verifica se um ano é bissexto(leap year)
                if (DateTime.IsLeapYear(ano))
                {
                    idadeBissexto++;
                }
            }
            return idadeBissexto;
        }

        public override string? ToString()
        {
            return $"Nome: {nome}\nProfissao: {profissao}\nIdade: {idade}";
        }
    }
}
