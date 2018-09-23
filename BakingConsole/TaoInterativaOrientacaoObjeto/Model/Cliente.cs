using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoInterativaOrientacaoObjeto_
{
     public class Cliente
        {

            public string Nome { get; private set; }
            public string CPF { get; private set; }

            public Cliente(string nome,  string cpf)
            {
                this.Nome = nome;
                this.CPF = cpf;
            }

            
         
        }
}
