using System;
namespace KITBOX_project
{
    //Class Dimensions pour créer et modifier les dimensions des objets Item
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

        public override  string ToString()
        {
            return String.Format("Height: {0}; Width: {1}; Depth: {2}", this.height, this.width, this.depth);
        }

    }

    //Class Item, classe generale des articles 
    public class Item
    {
        protected string code;
        protected string color;

        protected double price;

        public Item(string code, string color, double price)
        {
            this.code = code;

            this.color = color;
            this.price = price;

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
            try
            {
                return string.Format("{0}; {1}; {2};", code, color, price );
            }
            catch (Exception e) { throw new DimensionsException(e.Message); }

        }


    }

    public class Battens : Item
    {
        Dimensions dimensions;
        public Battens(string code, double price, string color = null, Dimensions dimensions = null) : base(code, color, price)
        {
            this.dimensions = dimensions;

        }

        //Permet d'ajouter les dimensions à l'objet et controler les valeurs 
        public string SetDimensions(Dimensions dimensions)
        {

            if (dimensions.Depth != 0 || dimensions.Width != 0 || dimensions.Height <= 0)
            {

                return string.Format("inappropriate dimensions");


            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("Battens: {0}", dimensions.ToString());

            }

        }
        public int Height
        {
            get { return dimensions.Height; }
        }
        public override string ToString()
        {
            return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
        } 
    }


    public class LRpanel : Item
    {
        private Dimensions dimensions;

		public LRpanel(string code, double price, string color,Dimensions dimensions = null) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            
            if (dimensions.Depth <= 0 || dimensions.Width != 0 || dimensions.Height <= 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("LRpanel: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}

	}

    public class UDpanel : Item
    {
        private Dimensions dimensions;
        public UDpanel(string code, double price, string color, Dimensions dimensions) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth <= 0 || dimensions.Width <= 0 || dimensions.Height != 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("LRpanel: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}


    }

    public class BackPanel : Item
    {
        private Dimensions dimensions;
        public BackPanel(string code, double price, string color,Dimensions dimensions) : base(code, color, price)
        {
            this.dimensions = dimensions;

        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth != 0 || dimensions.Width <= 0 || dimensions.Height <= 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("BackPanel: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}

	}

    public class FBCrossbar : Item

    {
        private Dimensions dimensions;
        public FBCrossbar(string code, double price, string color = null, Dimensions dimensions = null) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth != 0 || dimensions.Width <= 0 || dimensions.Height != 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("FBCrossbar: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}

    }

    public class LRcrossbar : Item
    {
        private Dimensions dimensions;
        public LRcrossbar(string code, double price, string color = null, Dimensions dimensions=null) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth <= 0 || dimensions.Width != 0 || dimensions.Height != 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("LRcrossbar: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}


	}

    public class Door : Item
    {
        private Dimensions dimensions;
        public Door(string code, double price, string color, Dimensions dimensions) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth != 0 || dimensions.Width <= 0 || dimensions.Height <= 0)
            {
                return string.Format("Inapprotiate dimensions");
            }
            else
            {
               this.dimensions = dimensions;

                return string.Format("Door: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}
    }

    public class AngleBar : Item
    {
        private Dimensions dimensions;
        public AngleBar(string code, double price, string color,Dimensions dimensions=null) : base(code, color, price)
        {
            this.dimensions = dimensions;
        }
        public string SetDimensions(Dimensions dimensions)
        {
            if (dimensions.Depth != 0 || dimensions.Width != 0 || dimensions.Height <= 0)
            {
                throw new Exception("Inapprotiate dimensions");
            }
            else
            {
                this.dimensions = dimensions;

                return string.Format("AngleBar: {0}", dimensions.ToString());

            }

		}
		public override string ToString()
		{
			return string.Format("{0} ; {1} ; {2} ; \t{3} Euros", code, color, dimensions.ToString(), price);
		}

    }
    // class qui regroupe les proprietes du casier et permet de les modifier
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
      

        public Rack(Battens battens, LRpanel lrpanel, UDpanel udpanel, BackPanel backpanel,
                    FBCrossbar fbcrossbar, LRcrossbar lrcrossbar, AngleBar anglebar, Door door = null)
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

        public override string ToString()

        {
            return String.Format("\n {0} \tx4\n {1} \tx2\n {2} \tx2\n {3}\tx1\n {4}\tx4\n {5}\tx4\n {6}\tx4\n {7}\tx1 \n", battens.ToString() , lrpanel.ToString() ,
                                udpanel.ToString() , backpanel.ToString() , fbcrossbar.ToString() , lrcrossbar.ToString() , anglebar.ToString() , door.ToString() );
        }

    }
    public class DimensionsException : Exception
    {
        public DimensionsException(string msg) : base(msg)
        { }
    }

    // class armoire qui regroupe les casiers et permet de les modifier
    public class Shelf
    {
        private  Rack[] RackList = new Rack[7];

        public Shelf()
        {}
        int num = 0;
        int height_battens = 0;
        public void AddRack(Rack rack)

        {
            try
            {
                RackList[num] = rack;
                height_battens += rack.BAttens.Height + 4;
                num += 1;
            }
            catch (Exception e)
            {
                throw new DimensionsException(e.Message);

            }

        }
        public void DellRack(int rack_num)
        {
            RackList[rack_num - 1] = null;
        }

        public int Height
        {
            get { return height_battens; }
        }
        public  string  ToString (int num)
        {
            return string.Format("{0}",RackList[num-1].ToString()) ; 
        }





    }
}
