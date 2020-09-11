using System;
using System.Collections.Generic;
using System.Text;

namespace POO3C1_27e29
{
    class BLL_música
        // Dupla: Roseane Tamires e Rafael Barros 
    {
        private DALMysql DaoBanco = new DALMysql();
        public Boolean Autenticar(int idmusica, string nome, string nomeautor, int idgravadora, int idCd)
        {
            string consulta = string.Format($@"select * from TBML_Musica where idMusica = '{idMusica}' and nome = '{nome}' and nomeAutor = '{nomeautor}' and idGravadora = '{idgravadora}' and idCD = '{idCd}' ;");
            DataTable dt = DaoBanco.executarConsulta(consulta);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable ListarMusicas()
        {
            string sql = string.Format($@"select * from TBL_Musica;");
            return DaoBanco.executarConsulta(sql);
        }



        public void AdicionarMusica(DTO_musica objMusica)
        {
            DTO_musica musica = new DTO_musica();
            string sql = string.Format($@"insert into tbl_musica values (null, '{objMusica.Nome}', 
                                                                                '{objMusica.NomeAutor}',
                                                                                '{objMusica.Idgravadora}',
                                                                                '{objMusica.IdCD}'); ");
            DaoBanco.executarComando(sql);

        }

        public void ExcluirMusica(DTO_musica objMusica)
        {
            string sql = string.Format($@"delete from tbl_musica where idMusica = '{objMusica.Idmusica}';");
            DaoBanco.executarComando(sql);
        }

        public void AlterarMusica(DTO_musica objdto)
        {
            string sql = string.Format($@"UPDATE tbl_musica set nome = '{objdto.Nome}',
                                                                nomeAutor = '{objdto.NomeAutor}',
                                                                idGravadora = '{objdto.Idgravadora}',
                                                                idCD = '{objdto.IdCD}'
                                        where idMusica = '{objdto.Idmusica}';");
            DaoBanco.executarComando(sql);
        }
    }
}
    }
}
