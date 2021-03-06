﻿using System;
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
        private static readonly String name = "Battens";

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
        private static readonly String name = "Left/right panel";

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
            return string.Format("{0} - Height : {1} - Width : {2} - Color : {3} ", Name, height, dimensions.Width, base.color);
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
        private static readonly String name = "Up/down panel";

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
        private static readonly String name = "Back panel";

        public BackPanel(int height, string color, Dimensions dimensions) : base(color , dimensions)
        { this.height = height; }

        public override string ToString()
        {
            return string.Format("{0} - Height : {1} - Width : {2} - Color : {3}", name ,height , dimensions.Width, base.Color );
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
        private static readonly String name = "Back crossbar";

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
        private static readonly String name = "Front crossbar";

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
        private static readonly String name = "Left/right crossbar";

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
        private static readonly String name = "Door";

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
            return string.Format("{0} - Height : {1} - Width {2} - Color : {3} ", name , height , dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }
    }

	public class AngleBar : Item
	{
        public static int H_angle = 0;
        string code;
        private static readonly String name = "Angle bar";

        public AngleBar(string color, Dimensions dimensions) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Height : {1} - Color : {2} " , name , AngleBar.H_angle ,base.Color);
        }
        public String Name
        {
            get { return name; }
        }

        public override string Code()
        {
            if (color == "Brun")
            {
                code = "'COR" + H_angle + UserControl2.color_Angle + "BR'";
            }

            if (color == "Verre")
            {
                code = "'COR" + H_angle + UserControl2.color_Angle + "VE'";
            }
            if (color == "Blanc")
            {
                code = "'COR" + H_angle + UserControl2.color_Angle + "BL'";
            }

            if (color == "Galvanisé")
            {
                code = "'COR" + H_angle + UserControl2.color_Angle + "GL'";
            }
            if (color == "Noir")
            {
                code = "'COR" + H_angle + UserControl2.color_Angle + "NR'";
            }

            return code;
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
