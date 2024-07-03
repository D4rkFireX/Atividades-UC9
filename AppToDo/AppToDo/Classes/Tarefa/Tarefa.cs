/**********************************************************************************
 Nome da Classe: Tarefa
    Dt. Criação: 02/02/2024
      Descrição: Esta classe é responsável pelo objeto Tarefa.
  Dt. Alteração: --/--/---- 
     Observação: Status da tarefa será 
                 0 - Feito, 
                 1 - Em Andamento, 
                 2 - Não Feito e 
                 3 - Abandonada.
     Criado Por: mFacine
***********************************************************************************/
using System;

namespace AppToDo
{
    public class Tarefa
    {
        ~Tarefa()
        {
        }

        #region Atributos
        //Atributos privados
        private int v_Cod_Tarefa = -1;
        private int v_Cod_Usuario = -1;
        private int v_Cod_Categoria = -1;
        private string v_Tit_Tarefa = "";
        private string v_Desc_Tarefa = "";
        private DateTime v_Term_Tarefa = DateTime.MinValue;
        private int v_Stat_Tarefa = 0;
        private int v_Prior_Tarefa = 0;
        #endregion

        #region Métodos
        //Métodos Públicos
        public int Cod_Tarefa 
        { 
            get => v_Cod_Tarefa; 
            set => v_Cod_Tarefa = value; 
        }

        public int Cod_Usuario 
        { 
            get => v_Cod_Usuario; 
            set => v_Cod_Usuario = value; 
        }

        public int Cod_Categoria 
        { 
            get => v_Cod_Categoria; 
            set => v_Cod_Categoria = value; 
        }

        public string Tit_Tarefa 
        { 
            get => v_Tit_Tarefa; 
            set => v_Tit_Tarefa = value; 
        }

        public string Desc_Tarefa 
        { 
            get => v_Desc_Tarefa; 
            set => v_Desc_Tarefa = value; 
        }

        public DateTime Term_Tarefa 
        { 
            get => v_Term_Tarefa; 
            set => v_Term_Tarefa = value; 
        }

        public int Stat_Tarefa 
        { 
            get => v_Stat_Tarefa; 
            set => v_Stat_Tarefa = value; 
        }

        public int Prior_Tarefa 
        { 
            get => v_Prior_Tarefa; 
            set => v_Prior_Tarefa = value; 
        }
        #endregion
    }
}
