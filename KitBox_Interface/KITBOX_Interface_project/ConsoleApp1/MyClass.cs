using System;
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

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

        public int Height
        {
            get { return dimensions.Height; }
        }

        public int Width
        {
            get { return dimensions.Width; }
        }

        public int Depth
        {
            get { return dimensions.Depth; }

        }

        public override string ToString()
		{
				return "Color: " + color;

		}
	}

    public class Battens : Item
    {
        private static readonly String name = "Tasseau";
        private int height;

        //Battens has a height
        public Battens(int height, Dimensions dimensions, string color = null) : base(color, dimensions)
        {
            this.height = dimensions.Height;
        }

        public new string ToString()
        {
            return string.Format("{0}- heigth: {1}", Name, height);
        }
        public String Name 
        {
            get { return name; }
        }

    }


	public class LRpanel : Item
	{
        private static readonly String name = "Panneau GD";

        public LRpanel(string color, Dimensions dimensions) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0}- Heigth: {1} - Width: {2} - Color: {3} ", Name, dimensions.Height, dimensions.Width, base.color);
        }
        public String Name
        {
            get { return name; }
        }
         
    }

    public class UDpanel : Item
	{
        private static readonly String name = "Panneau HB";

        public UDpanel(string color , Dimensions dimensions) : base(color , dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0}- Width: {1} - Deph: {2} - Color: {3} ", Name , dimensions.Width , dimensions.Depth, base.Color);
        }
        public String Name
        {
            get { return name; }
        }


    }

	public class BackPanel : Item
    {
        private static readonly String name = "Panneau Ar";

        public BackPanel(string color, Dimensions dimensions) : base(color , dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Heigth: {1} - Width: {2} - Color: {3}", Name , dimensions.Height , dimensions.Width, base.Color );
        }
        public String Name
        {
            get { return name; }
        }


    }

    public class BCrossbar : Item

    {
        private static readonly String name = "Traverse Ar";

        public BCrossbar(Dimensions dimensions,string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Width: {1} - Colo: {2}" , Name , dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }


    }
    public class FCrossbar : Item

    {
        private static readonly String name = "Traverse Av";

        public FCrossbar(Dimensions dimensions , string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Width: {1} - Color: {2}", Name, dimensions.Width, base.Color);
        }
        public String Name
        {
            get { return name; }
        }

    }

    public class LRcrossbar : Item
    {
        private static readonly String name = "Traverse GD";

        public LRcrossbar( Dimensions dimensions , string color = null) : base(color, dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Deph: {1} - Color:  {2}", Name , dimensions.Depth , base.Color );
        }
        public String Name
        {
            get { return name; }
        }
        


    }

    public class Door : Item
	{
        private static readonly String name = "Porte";

        public Door(string color , Dimensions dimensions) : base(color , dimensions)
        { }

        public override string ToString()
        {
            return string.Format("{0} - Heigth: {1} - Width {2} - Color: {3} ", Name , dimensions.Height , dimensions.Width, base.Color);
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
            return string.Format("{0} - Heigth: {1} - Color: {2} " , Name , dimensions.Height,base.Color);
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
                    FCrossbar fcrossbar, BCrossbar bcrossbar, LRcrossbar lrcrossbar, AngleBar anglebar, Door door = null)
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
