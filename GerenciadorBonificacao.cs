using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificao();
        }
   

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
