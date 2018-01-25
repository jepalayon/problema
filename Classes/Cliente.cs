using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor Classe - construtor sempre tem o mesmo nome da classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>
        public Cliente(string nome, string telefone, string cpf) 
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        /// <summary>
        /// Construtor com parâmetro telefone inteiro
        /// </summary>
        /// <param name="telefone"></param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public Cliente() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(caminhoBaseClientes()))
            {
                StreamWriter r = new StreamWriter(caminhoBaseClientes());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                    r.WriteLine(linha);
                }

                r.Close();
            }
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);

                        /*var cliente = new Cliente {
                            Nome = clienteArquivo[0] ,
                            Telefone = clienteArquivo[1] ,
                            CPF = clienteArquivo[2]
                        };*/
                        

                        clientes.Add(cliente);
                    }
                }
              
            }
            return clientes;
        }
    }
}
