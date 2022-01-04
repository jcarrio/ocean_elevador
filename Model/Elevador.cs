using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        // Determina o andar atual, sendo térreo igual a 0 (zero)
        private int AndarAtual { get; set; }

        // Determina o total de andares, desconsiderando o térreo
        private int TotalAndares { get; set; }

        // Determina a quantidade de pessoas suportada pelo elevador
        private int CapacidadeElevador { get; set; }

        // Determina quantas pessoas estão no elevador
        private int PessoasElevador { get; set; }

        // Inicializa o elevador com a capacidade e o total de andares do prédio
        // Os elevadores sempre começam no térreo e vazios
        public void Inicializar(int capacidade, int andares) {
            CapacidadeElevador = capacidade;
            TotalAndares = andares;
            AndarAtual = 0;
            PessoasElevador = 0;
        }

        // Acrescenta uma pessoa ao elevador, somente se ainda houver espaço
        public bool Entrar()
        {
            if (PessoasElevador < CapacidadeElevador)
            {
                PessoasElevador++;
                return true;
            }
            else
                return false;
        }

        // Remove uma pessoa do elevador, se ainda houver alguém dentro dele
        public bool Sair()
        {
            if (PessoasElevador > 0)
            {
                PessoasElevador--;
                return true;
            }
            else
                return false;
        }

        // Sobe um andar, se ainda não estiver no último andar
        public bool Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                return true;
            }
            else
                return false;
        }

        // Desce um andar, se ainda não estiver no térreo
        public bool Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                return true;
            }
            else
                return false;
        }

        // Retorna a quantidade de pessoas no elevador
        public int Pessoas()
        {
            return PessoasElevador;
        }

        // Retorna o andar atual
        public int Andar()
        {
            return AndarAtual;
        }
    }
}
