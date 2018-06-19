using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using KITBOX_project;
using ConsoleApp1;
public class Broker
{
    OleDbConnection connection;
    OleDbCommand command;
    string item;
    string finalize;
    string prix_unitaire;
    string available;
    string order = null;
    //Rack item;
    private void connectTo()
    {
        connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\Ecole\ABLODOSS\3eme\P2\projet informatique\projet\kitboxteam\KitBox_DB\KitBox_DB\KitBox_DB.mdb");
        command = connection.CreateCommand();
        

       
    }
    public Broker() 
    {
        connectTo();
    }

    // delete elements from data base
    public void deleteItems()
    {

        int H_Angle = 0; // Height of Angle irons
        connection.Open();

        foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
        {
            H_Angle += casier.Value.Lrpanel.Height;

            //delete PanelAR
            command.CommandText = "UPDATE PanneauAr SET Enstock = Enstock - 1 " +
                "WHERE code = " + casier.Value.Backpanel.Code();
            command.ExecuteNonQuery();

            // delete panelGD
            command.CommandText = "UPDATE PanneauGD SET Enstock = Enstock - 2 " +
                "WHERE code = " + casier.Value.Lrpanel.Code();
            command.ExecuteNonQuery();

            // delete panelHB
            command.CommandText = "UPDATE PanneauHB SET Enstock = Enstock - 2 " +
                "WHERE code = " + casier.Value.Udpanel.Code();
            command.ExecuteNonQuery();

            // delete CrossbarAr
            command.CommandText = "UPDATE TraverseAr SET Enstock = Enstock - 1 " +
                "WHERE code = " + casier.Value.Bcrossbar.Code();
            command.ExecuteNonQuery();

            // delete CrossbarAv
            command.CommandText = "UPDATE TraverseAv SET Enstock = Enstock - 1 " +
                "WHERE code = " + casier.Value.Fcrossbar.Code();
            command.ExecuteNonQuery();

            // delete CrossbarGD
            command.CommandText = "UPDATE TraverseGD SET Enstock = Enstock - 2 " +
                "WHERE code = " + casier.Value.Lrcrossbar.Code();
            command.ExecuteNonQuery();

            //delete battens
            command.CommandText = "UPDATE Tasseau SET Enstock = Enstock - 4 " +
            "WHERE code = " + casier.Value.BAttens.Code();
            command.ExecuteNonQuery();

            // delete doors
            if (casier.Value.Door != null)
            {
                command.CommandText = "UPDATE Porte SET Enstock = Enstock - 1 " +
                "WHERE code = " + casier.Value.Door.Code();
                command.ExecuteNonQuery();
            }
        }

        // delete Angle_irons
        command.CommandText = "UPDATE Corniere SET Enstock = Enstock - 4 " +
            "WHERE code = 'COR" + H_Angle + UserControl2.color_Angle + "'";
        command.ExecuteNonQuery();

        connection.Close();
    }

    //price of items
    public string printPrice(KITBOX_project.Item item, string table)
    {
        connection.Open();

        string code_item = item.Code();

        command.CommandText = "SELECT * FROM " + table +
            " WHERE code = " + code_item;
        command.CommandType = CommandType.Text;

        OleDbDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            prix_unitaire = reader["PrixClient"].ToString();
        }
        connection.Close();

        return prix_unitaire;
    }

    // check Availability of items
    public string Available(KITBOX_project.Item item, string table)
    {
        connection.Open();

        int stock; 
        string code_item = item.Code();

        command.CommandText = "SELECT * FROM " + table +
            " WHERE code = " + code_item;
        command.CommandType = CommandType.Text;

        OleDbDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            stock = Convert.ToInt32(reader["Enstock"].ToString());

            if(stock > 0)
            {
                available = "Yes";
            }
            else
            {
                available = "No";
            }

        }
        connection.Close();
        return available;
    }

    // insert order no finish in the database
    public void Insert(string nr, string name, string phone, string email, double deposit, string order, string finalized)
    {
        connection.Open();

        command.CommandText = "INSERT INTO Commande(Numéro_commande, Nom, Telephone, Email, Acompte, Commande, Finalized) " +
            "VALUES('" + nr + "', '" + name + "', '" + phone + "', '" + email + "', '" + deposit + "', '" + order + "', '" + finalized + "')";
        command.ExecuteNonQuery();

        connection.Close();
    }

    // search order
    public string Order(string name)
    {
        connection.Open();
        try
        {
            command.CommandText = "SELECT * FROM Commande" +
                " WHERE Nom = '" + name + "' OR Numéro_commande = '" + name + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                order = reader["Commande"].ToString();
            }

            if (order != null)// order exist ? 
            {
                return order;
            }

            else
            {
                return "No order exist for this client";
            }

        }

        catch (Exception)
        {
            return "No order exist for this client";
        }

        finally
        {
            connection.Close();
        }
    }

    // finalizedan order
    string commande;
    public string UpdateOrder(string name)
    {
        
        connection.Open();
        double price;
        command.CommandText = "SELECT * FROM Commande" +
            " WHERE Nom = '" + name + "'";
        command.CommandType = CommandType.Text;

        OleDbDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            price = Convert.ToDouble(reader["Acompte"].ToString()) * 2;
            
            finalize = Convert.ToString(price);

            commande = reader["Commande"].ToString() + "\r\n\r\nFinal price : " + finalize; ;
        }
        connection.Close();

        connection.Open();
        command.CommandText = "UPDATE Commande " +
            "SET Finalized = 'Yes', Acompte = '" + finalize + "', Commande = '" + commande + " euros' WHERE Nom = '" + name + "'";
        command.ExecuteNonQuery();

        connection.Close();
        return "The order was finalized";
    }

    // see if an order is finalized
    public string finalized(string name)
    {
        connection.Open();

        command.CommandText = "SELECT * FROM Commande" +
            " WHERE Nom = '" + name + "'";
        command.CommandType = CommandType.Text;

        OleDbDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            finalize = reader["Finalized"].ToString();
        }
        connection.Close();

        return finalize;
    }

    // check available of all items
    public string ItemStock(string code)
    {
        connection.Open();

        if (code.Substring(0, 3) == "POR")
        {
            command.CommandText = "SELECT * FROM Porte" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "COR")
        {
            command.CommandText = "SELECT * FROM Corniere" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "PAR")
        {
            command.CommandText = "SELECT * FROM PanneauAR" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "PAG")
        {
            command.CommandText = "SELECT * FROM PanneauGD" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "PAH")
        {
            command.CommandText = "SELECT * FROM PanneauHB" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "TAS")
        {
            command.CommandText = "SELECT * FROM Tasseau" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "TRR")
        {
            command.CommandText = "SELECT * FROM TraverseAr" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "TRF")
        {
            command.CommandText = "SELECT * FROM TraverseAv" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else if (code.Substring(0, 3) == "TRG")
        {
            command.CommandText = "SELECT * FROM TraverseGD" +
                " WHERE code = '" + code + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "Price : \t" + reader["PrixClient"].ToString() + " euro(s) \r\n" +
                    "Stock : \t" + reader["Enstock"].ToString() + "\r\n";
            }
        }

        else
        {
            item = "item no found";
        }
        connection.Close();
        return item;
    }
}