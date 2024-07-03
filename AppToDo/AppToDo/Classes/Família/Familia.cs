/**********************************************************************************
 Nome da Classe: Familia
    Dt. Criação: 02/02/2024
      Descrição: Esta classe é responsável pelo objeto Familia.
  Dt. Alteração: --/--/---- 
     Observação:
     Criado Por: mFacine
***********************************************************************************/
namespace AppToDo
{
    public class Familia
    {
        ~Familia()
        {
        }

        #region Atributos
        //Atributos privados
        private int v_Cod_Familia = -1;
        private string v_Nm_Familia = "";

        #endregion

        #region Métodos
        //Métodos Públicos
        public int Cod_Familia
        {
            get => v_Cod_Familia;
            set => v_Cod_Familia = value;
        }

        public string Nm_Familia
        {
            get => v_Nm_Familia;
            set => v_Nm_Familia = value;
        }

        #endregion
    }
}
