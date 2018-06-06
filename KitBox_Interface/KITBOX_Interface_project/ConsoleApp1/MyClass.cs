using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using KITBOX_project;
using ConsoleApp1;
using System.ComponentModel;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KITBOX_project
{
	//Class Dimensions used for all item dimension.
	public class Dimensions
	{
		private int height;
		private int width;
		private int depth;

		public Dimensions(int height, int width, int depth)
		{
			this.height = height;
			this.width = width;
			this.depth = depth;
		}

		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public int Depth
		{
			get { return depth; }
			set { depth = value; }

		}

		public override string ToString()
		{
			return String.Format("Height: {0}; Width: {1}; Depth: {2}", Height, Width, Depth);
		}

	}

	//Abstract class item used to create all others item.
	public abstract class Item
	{
		
		protected string color;
        protected Dimensions dimensions;




        public Item(string color, Dimensions dimensions)
		{
			
			this.color = color;
            this.dimensions = dimensions;

		}

		public virtual string Color
		{
			get { return color; }
			set { color = value; }
		}

        public virtual int Height
        {
            get { return dimensions.Height; }
            set { dimensions.Height = value; }
        }

        public int Width
        {
            get { return dimensions.Width; }
            set { dimensions.Width = value; }
        }

        public int Depth
        {
            get { return dimensions.Depth; }
            set { dimensions.Depth = value; }
        }

        public override string ToString()
		{
				return "Color: " + color;

		}

        public virtual string Code()
        {
            return null;
        }


	}

    public class Battens : Item
    {
        string code;
        int height;
        private static readonly String name = "Tasseaux";

        public Battens(int height, Dimensions dimensions, string color = null) : base(color, dimensions)
        { this.height = height; }

        public override string ToString()
        {
            return string.Format("{0} - height : {1}", name, height);
        }
        public String Name 
        {
            get { return name; }
        }
        public override string Code()
        {
            if (this.height == 32)
            {
                code = "'TAS27'";

            }
            if (this.height == 42)
            {
                code = "'TAS37'";

            }
            if (this.height == 52)
            {
                code = "'TAS47'";

            }
            return code;
        }

        public override int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

    }


	public class LRpanel : Item
	{
        string code;
        int height;
        private static readonly String name = "Panneaux Gauche/Droite";

        public LRpanel(int height, string color, Dimensions dimensions) : base(color, dimensions)
        { this.height = height; }

        public override string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} - Heigth : {1} - Width : {2} - Color : {3} ", Name, height, dimensions.Width, base.color);
        }
        public String Name
        {
            get { return name; }
        }
        public override string Code()
        {
            if(color == "Brun")
            {
                code = "'PAG" + this.height + dimensions.Depth+ "BR'";
            }
            if (color == "Blanc")
            {
                code = "'PAG" + this.height + dimensions.Depth + "BL'";
            }

            return code;
        }
         
    }

    public class UDpanel : Item
	{
        string code;
        private static readonly String name = "Panneaux Haut/Bas";

        public UDpanel(string color , Dimensions dimensions) : base(color , dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Width : {1} - Deph : {2} - Color : {3} ", name , dimensions.Width , dimensions.Depth, base.Color);
        }
        public String Name
        {
            get { return name; }
        }
        public override string Code()
        {
            if (color == "Brun")
            {
                code = "'PAH" + dimensions.Depth + dimensions.Width + "BR'";
            }
            if (color == "Blanc")
            {
                code = "'PAH" + dimensions.Depth + dimensions.Width + "BL'";
            }

            return code;
        }



    }

	public class BackPanel : Item
    {
        string code;
        int height;
        private static readonly String name = "Panneau Arrière";

        public BackPanel(int height, string color, Dimensions dimensions) : base(color , dimensions)
        { this.height = height; }

        public override string ToString()
        {
            return string.Format("{0} - Heigth : {1} - Width : {2} - Color : {3}", name ,height , dimensions.Width, base.Color );
        }
        public String Name
        {
            get { return name; }
        }

        public override int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public override string Code()
        {
            if (color == "Brun")
            {
               code = "'PAR" + this.height + dimensions.Width + "BR'";
            }
            if (color == "Blanc")
            {
                code = "'PAR" + this.height + dimensions.Width + "BL'";
            }

            return code;
        }


    }

    public class BCrossbar : Item
    {
        private static readonly String name = "Traverse Arrière";

        public BCrossbar(Dimensions dimensions,string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Width : {1} - Color : {2}" , name , dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }
        public override string Code()
        {
            string code = "'TRR" + dimensions.Width + "'";
            return code;
        }


    }
    public class FCrossbar : Item

    {
        private static readonly String name = "Traverse Avant";

        public FCrossbar(Dimensions dimensions , string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Width : {1} - Color : {2}", name, dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }

        public override string Code()
        {
            string code = "'TRF" + dimensions.Width + "'";
            return code;
        }

    }

    public class LRcrossbar : Item
    {
        private static readonly String name = "Traverse Gauche/Droite";

        public LRcrossbar( Dimensions dimensions , string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Depth : {1} - Color :  {2}", name , dimensions.Depth , base.Color );
        }
        public String Name
        {
            get { return name; }
        }

        public override string Code()
        {
            string code = "'TRG" + dimensions.Depth + "'";
            return code;
        }



    }

    public class Door : Item
	{
        string code;
        int height;
        private static readonly String name = "Porte";

        public Door(int height, string color , Dimensions dimensions) : base(color , dimensions)
        { this.height = height; }

        public override string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public override string Code()
        {
            if (color == "Brun")
            {
                code = "'POR" + this.height + dimensions.Width + "BR'";
            }

            if (color == "Verre")
            {
                 code = "'POR" + this.height + dimensions.Width + "VE'";
            }
            if (color == "Blanc")
            {
                code = "'POR" + this.height + dimensions.Width + "BL'";
            }

            return code;
        }


        public override string ToString()
        {
            return string.Format("{0} - Heigth : {1} - Width {2} - Color : {3} ", name , height , dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }
    }

	public class AngleBar : Item
	{
        private static readonly String name = "Corniere";

        public AngleBar(string color, Dimensions dimensions) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Heigth : {1} - Color : {2} " , name , Height ,base.Color);
        }
        public String Name
        {
            get { return name; }
        }
    }

	// class qui regroupe les proprietes du casier et permet de les modifier
	public class Rack
	{
		private Battens battens;
		private LRpanel lrpanel;
		private UDpanel udpanel;
		private BackPanel backpanel;
		private FCrossbar fcrossbar;
        private BCrossbar bcrossbar;
        private LRcrossbar lrcrossbar;
		private AngleBar anglebar;
		private Door door;


        public Rack(Battens battens, LRpanel lrpanel, UDpanel udpanel, BackPanel backpanel,
                    FCrossbar fcrossbar, BCrossbar bcrossbar, LRcrossbar lrcrossbar, AngleBar anglebar, Door door)
		{
			this.battens = battens;
			this.lrpanel = lrpanel;
			this.udpanel = udpanel;
			this.backpanel = backpanel;
			this.fcrossbar = fcrossbar;
            this.bcrossbar = bcrossbar;
            this.lrcrossbar = lrcrossbar;
			this.anglebar = anglebar;
			this.door = door;

		}

		public Battens BAttens
		{
			get { return battens; }
			set { battens = value; }

		}
		public LRpanel Lrpanel
		{
			get { return lrpanel; }
			set { lrpanel = value; }

		}
		public UDpanel Udpanel
		{
			get { return udpanel; }
			set { udpanel = value; }

		}
		public BackPanel Backpanel
		{
			get { return backpanel; }
			set { backpanel = value; }

		}
		public BCrossbar Bcrossbar
		{
			get { return bcrossbar; }
			set { bcrossbar = value; }

		}
        public FCrossbar Fcrossbar
        {
            get { return fcrossbar; }
            set { fcrossbar = value; }

        }
        public LRcrossbar Lrcrossbar
		{
			get { return lrcrossbar; }
			set { lrcrossbar = value; }

		}
		public AngleBar Anglebar
		{
			get { return anglebar; }
			set { anglebar = value; }

		}
		public Door Door
		{
			get { return door; }
			set { door = value; }

		}

		public override string ToString()

		{
			return "\n" + battens.ToString() + "\n" + lrpanel.ToString() + "\n" 
                        + udpanel.ToString() + "\n" + backpanel.ToString() + "\n" + bcrossbar.ToString() 
                        + "\n" + fcrossbar.ToString() + "\n" + lrcrossbar.ToString() 
                        + "\n" + anglebar.ToString() + "\n" + door.ToString();
		}

	}
	
}

public class Broker
{
    OleDbConnection connection;
    OleDbCommand command;
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

    public List<string > viewData()
    {
        List<string> dataList
            = new List<string>();

        try
        {
            command.CommandText = "SELECT * FROM Porte";
            command.CommandType = CommandType.Text;
            connection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string code = reader["PK_Porte"].ToString() + " - "+ reader["Enstock"].ToString() + "; ";
                dataList.Add(code);
            }

            return dataList;
              
        }

        catch (Exception)
        {
            throw;
        }
        finally
        {
            if(connection != null)
            {
                connection.Close();
            }

        }
    }

    // delete elements from data base
    public void deleteItems()
    {
        switch (UserControl2.color_Angle)
        {
            case "Blanc":
                UserControl2.color_Angle = "BL";
                break;
            case "Verre":
                UserControl2.color_Angle = "VE";
                break;
            case "Brun":
                UserControl2.color_Angle = "BR";
                break;
            case "Galvanisé":
                UserControl2.color_Angle = "GL";
                break;
            case "Noir":
                UserControl2.color_Angle = "NR";
                break;
        }

        int H_Angle = 0; // Height of Angle irons
        connection.Open();

        foreach (KeyValuePair<string, Rack> casier in UserControl2.command)
        {
            H_Angle += UserControl2.dimensions.Height + 4;

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
                available = "OUI";
            }
            else
            {
                available = "NON";
            }

        }
        connection.Close();
        return available;
    }

    // insert order no finish in the database
    public void Insert(string name, string phone, string email, double deposit, string order)
    {
        connection.Open();

        command.CommandText = "INSERT INTO Commande(Nom, Telephone, Email, Acompte, Commande) " +
            "VALUES('" + name+ "', '" + phone + "', '" + email + "', '" + deposit + "', '" + order + "')";
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
                " WHERE Nom = '" + name + "'";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                order = reader["Commande"].ToString();
            }

            if (order != null)
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
}