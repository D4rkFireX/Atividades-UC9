/*****************************************************************************
*           Nome: Connection
*      Descrição: Representa a classe de conexão com a Base de dados.
*                 A classe de Conexão possui o metodo: PathConnection (Público)
*    Dt. Criação: 09/02/2024
*  Dt. Alteração: --/--/----
* Obs. Alteração: -------------------
*     Criada por: mFacine
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo
{
    public static class Connection
    {
        /**********************************************************************
        *  Nome: PathConnection
        *  Descrição: Responsável por retornar o caminho do banco da aplicação
        *  Retorna: string
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        ***********************************************************************/
        public static string PathConnection()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victor.grferreira\source\repos\AppToDo\AppToDo\BD_AppToDo.mdf; Integrated Security=True; Connect Timeout = 30"; 
        }
    }
}
