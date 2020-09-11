using System;
using System.Collections.Generic;
using System.Text;

namespace POO3C1_27e29
{
    class DTO_música
    // Dupla: Roseane Tamires e Rafael Barros 
    {
        private int idmusica, idgravadora, idCD;
        private string nome, nomeautor;

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
        public int Idmusica { get => idMusica; set => idMusica = value; }
        public int IdCD { get => idCD; set => idCD = value; }


        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("É necessário adicionar a música.");
                }

            }
            get { return this.nome; }
        }

        public string NomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeautor = value;
                }
                else
                {
                    throw new Exception("É necessário adicionar o autor.");
                }

            }
            get { return this.nomeautor; }
        }


    }
}
    }
}
