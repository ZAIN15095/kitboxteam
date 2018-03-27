using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace ConsoleApp1
{
    public class DATABASE: IITEM
    {
        //Item Item = new Item();
       
        public List<Item> GetItems(string code)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.cnnVal("kitDB")))

                {
                    var liste = connection.Query<Item>("dbo.LISTE @Code", new { Code = code }).ToList();
                    return liste;
                    
                }
        }


        public bool updateItems(Item ourItem)
        {


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.cnnVal("kitDB")))

            {
                var rowsAffected = connection.Execute($"UPDATE [kitbox] SET [Couleur] = '{ourItem.Couleur}' WHERE Code ='{ourItem.Code}'", ourItem);

                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;

            }


            

          

        }


    }

}







