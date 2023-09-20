using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
        public class Funcionario
        {


            public int Matricula { get; }
            public string Cpf { get; set; }

            public string Nome { get; set; }

            public string Endereco { get; set; }

            public string Nacionalidade { get; set; }

            public string Rg { get; set; }

            public string Telefone { get; set; }

            public string Cic { get; set; }

            public string EstadoCivil { get; set; }

            public string Sexo { get; set; }

            public DateTime DataDeAdimissao { get; set; }

            public DateTime DataDeNascimento { get; set; }

            public Funcionario(string cpf, string nome, string endereco, string nacionalidade, string rg, string telefone, string cic, string sexo, DateTime dataDeAdimissao, DateTime dataDeNascimento,string estadoCivil)
            {

                Cpf = cpf;
                Nome = nome;
                Endereco = endereco;
                Nacionalidade = nacionalidade;
                Rg = rg;
                Telefone = telefone;
                Cic = cic;
                Sexo = sexo;
                DataDeAdimissao = dataDeAdimissao;
                DataDeNascimento = dataDeNascimento;
                EstadoCivil = estadoCivil;
            }

        }
    }
