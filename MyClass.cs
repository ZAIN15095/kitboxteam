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
			if (dimensions.Depth != 0 || dimensions.Width != 0 || dimensions.Height <= 32 )
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

}
