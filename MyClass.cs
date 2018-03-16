using System;
namespace KITBOX_project
{
    public class Dimensions
    {
        private int height;
        private int width;
        private int depth;

        public Dimensions (int height, int width, int depth)
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

        public string ToSting()
        {
            return String.Format("Height: {0}; Width: {1}; Depth: {2}", this.height, this.width, this.depth); 
        }

    }


    public class Item
    {
        protected string code;
        protected string color;
        protected  Dimensions dimensions;
        protected double price;

        public Item (string code, string color, double price )
        {
            this.code = code;
            this.dimensions = null;
            this.color = color;
            this.price = price;

        }

        public Dimensions SetDimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

		public string Code
		{
			get { return code; }
			set { code = value; }
		}

        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}", this.code, this.dimensions, this.color, this.price); 
        }

       
    }

	public class Battens : Item
	{
        public Battens (string code, double price,string color = null) : base (code , color , price)
        {
            
        }

		public string  SetDimensions (Dimensions dimensions)
		{
			if (dimensions.Depth != 0 || dimensions.Width != 0 || dimensions.Height <= 0 )
			{
				throw new Exception("Inapprotiate dimensions");
			}
            else
            {
                base.dimensions = dimensions;

                return string.Format("Battens: {0}", dimensions.ToSting()); 
                
            }

		}



	}

    public class LRpanel : Item 
    {
		public LRpanel (string code, double price, string color) : base (code , color , price)
        {

		}
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth <= 0 || dimensions.Width != 0 || dimensions.Height <= 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("LRpanel: {0}", dimensions.ToSting());

			}

		}

    }

    public class UDpanel : Item 
    {
		public UDpanel(string code, double price, string color) : base (code , color , price)
        {

		}
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth <= 0 || dimensions.Width <= 0 || dimensions.Height != 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("LRpanel: {0}", dimensions.ToSting());

			}

		}
        
    }

    public class BackPanel : Item 
    {
        public BackPanel (string code, double price , string color) : base (code, color, price)
        {
            
        }
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth <= 0 || dimensions.Width != 0 || dimensions.Height <= 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("BackPanel: {0}", dimensions.ToSting());

			}

		}
    }

    public class FBCrossbar : Item
	
	{
        public FBCrossbar ( string code, double price, string color = null) : base (code, color, price)
        {
            
        }
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth != 0 || dimensions.Width <= 0 || dimensions.Height != 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("FBCrossbar: {0}", dimensions.ToSting());

			}

		}

    }

	public class LRcrossbar : Item
	{
		public LRcrossbar(string code, double price, string color = null) : base(code, color, price)
		{

		}
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth <= 0 || dimensions.Width != 0 || dimensions.Height != 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("LRcrossbar: {0}", dimensions.ToSting());

			}

		}

	}

    public class Door : Item 
    {
        public Door (string code, double price, string color ) : base (code, color, price)
        {
            
        }
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth != 0 || dimensions.Width <= 0 || dimensions.Height <= 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("Door: {0}", dimensions.ToSting());

			}

		}
    }

    public class AngleBar : Item 
    {
        public AngleBar (string code, double price, string color) : base(code, color, price)
        {
            
        }
		public string SetDimensions(Dimensions dimensions)
		{
			if (dimensions.Depth != 0 || dimensions.Width != 0 || dimensions.Height <= 0)
			{
				throw new Exception("Inapprotiate dimensions");
			}
			else
			{
				base.dimensions = dimensions;

				return string.Format("AngleBar: {0}", dimensions.ToSting());

			}

		}

    }

    public class Rack 
    {
        private Battens battens;
        private LRpanel lrpanel;
        private UDpanel udpanel;
        private BackPanel backpanel;
        private FBCrossbar fbcrossbar;
        private LRcrossbar lrcrossbar;
        private AngleBar anglebar;
        private Door door;

        public Rack (Battens battens, LRpanel lrpanel, UDpanel udpanel, BackPanel backpanel,
                    FBCrossbar fbcrossbar, LRcrossbar lrcrossbar, AngleBar anglebar, Door door = null )
        {
            this.battens = battens;
            this.lrpanel = lrpanel;
            this.udpanel = udpanel;
            this.backpanel = backpanel;
            this.fbcrossbar = fbcrossbar;
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
        public FBCrossbar Fbcrossbar
		{
			get { return fbcrossbar; }
			set { fbcrossbar = value; }

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
    
        public string ToString ()

        {
            return String.Format("\n {0} x4\n {1} x2\n {2} \n {3}\n {4}\n {5}\n {6}\n {7} \n", battens,lrpanel,
                                udpanel, backpanel,fbcrossbar, lrcrossbar,anglebar,door ); 
        }
        public double GetPrice()
        {
            return 0;
        }
    }

}
