using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario Carlos = new Funcionario();

            Carlos.Nome = "Carlos Almeida";
            Carlos.Cpf = "45401354508";
            Carlos.Salario = 2000;
            gerenciador.Registar(Carlos);
                      
            Console.WriteLine("bonificação do "+ Carlos.Nome + " sera no valor de: " + Carlos.GetBonificao());

            Funcionario Felipe = new Diretor();

            Felipe.Nome = "Felipe Delmondes";
            Felipe.Cpf = "454013131313";
            Felipe.Salario = 5000;
            gerenciador.Registar(Felipe);

            Console.WriteLine("bonificação do " + Felipe.Nome + " sera no valor de: " + Felipe.GetBonificao());
            Console.WriteLine("Total de bonificações: "+gerenciador.GetTotalBonificacao());

        }
    }
}
