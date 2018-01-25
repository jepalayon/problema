using Calculo;
using Classes;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace Constante
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Menu.Criar(); 

            

            var cliente = new Cliente();
            cliente.Nome = "Mané";
            cliente.Telefone = "21456786598";
            cliente.CPF = "45687545895";
            cliente.Gravar();

            //Cliente c = new Cliente();

            //Cliente c2 = new Cliente { Nome = "Mané", Telefone = "546485", CPF = "44987654" };

            var clientes = Cliente.LerClientes();
            foreach(Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
            }

            Console.ReadLine();

            //var l = new List<String>();

            /*var cliente2 = new Cliente();
            cliente2.Nome = "Shela";
            cliente2.Telefone = "15535648524";
            cliente2.CPF = "05485698456";
            cliente2.Gravar();*/
        }
    }
}
