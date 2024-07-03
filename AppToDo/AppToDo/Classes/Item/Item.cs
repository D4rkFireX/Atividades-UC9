/**********************************************************************************
 Nome da Classe: Item
    Dt. Criação: 02/02/2024
      Descrição: Esta classe é responsável pelo objeto Item.
  Dt. Alteração: --/--/---- 
     Observação:
     Criado Por: mFacine
***********************************************************************************/
namespace AppToDo
{
    public class Item
    {
        ~Item()
        {
        }

        #region Atributos
        //Atributos privados
        private int v_Cod_Item = -1;
        private int v_Cod_Tarefa = -1;
        private int v_Cod_Insumo = -1;
        private int v_Qtde_Item = 0;
        #endregion

        #region Métodos
        public int Cod_Item 
        { 
            get => v_Cod_Item; 
            set => v_Cod_Item = value; 
        }

        public int Cod_Tarefa 
        { 
            get => v_Cod_Tarefa; 
            set => v_Cod_Tarefa = value; 
        }

        public int Cod_Insumo 
        { 
            get => v_Cod_Insumo; 
            set => v_Cod_Insumo = value; 
        }

        public int Qtde_Item 
        { 
            get => v_Qtde_Item; 
            set => v_Qtde_Item = value; 
        }
        #endregion
    }
}
