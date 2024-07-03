/**********************************************************************************
 Nome da Classe: Insumo
    Dt. Criação: 02/02/2024
      Descrição: Esta classe é responsável pelo objeto Insumo.
  Dt. Alteração: --/--/---- 
     Observação:
     Criado Por: mFacine
***********************************************************************************/
namespace AppToDo
{
    public class Insumo
    {
        ~Insumo()
        {
        }

        #region Atributos
        //Atributos privados
        private int v_Cod_Insumo = -1;
        private int v_Cod_Familia = -1;
        private string v_Nm_Insumo = "";
        private bool v_Frac_Insumo = false;



        #endregion

        #region Métodos
        //Métodos Públicos
        public int    Cod_Insumo 
        { 
            get => v_Cod_Insumo; 
            set => v_Cod_Insumo = value;
        }

        public int    Cod_Familia 
        { 
            get => v_Cod_Familia; 
            set => v_Cod_Familia = value; 
        }

        public string Nm_Insumo 
        { 
            get => v_Nm_Insumo; 
            set => v_Nm_Insumo = value; 
        }

        public bool   Frac_Insumo 
        { 
            get => v_Frac_Insumo; 
            set => v_Frac_Insumo = value; 
        }
        #endregion
    }
}
