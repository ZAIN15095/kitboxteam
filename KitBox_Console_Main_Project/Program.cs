using System;
using KITBOX_project;

namespace Main_Project
{
     
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t*** KIT_BOX beta ***\t\t\t"); 
            
            while (true )
            {
                Console.WriteLine("Céez votre armoire personnalisée (^_^)\nEntrer la largeur :");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEntrez la profondeur : ");
                int depth = Convert.ToInt32(Console.ReadLine());
                Console.Write("la base de votre étagere a ete choisie: "+weight+" Cm x "+depth+" Cm");
                Console.Write("\nEntrez la hauteur du premier casier : ");
                int height = Convert.ToInt32(Console.ReadLine());

                Dimensions UDpanel_dim = new Dimensions(0, weight, depth);
                Dimensions LRpanel_dim = new Dimensions(height, 0, depth);
                Dimensions Battens_dim = new Dimensions(height, 0, 0);
                Dimensions Backpannel_dim = new Dimensions(height, weight , 0 );
                Dimensions FBcrossbar_dim = new Dimensions(0, weight, 0);
                Dimensions LRcrossbar_dim = new Dimensions(0, 0, depth); 

                Console.Write("\nEntrez la couleur de votre casier: ");
                string color = Console.ReadLine() ;

                Console.Write("\nEntrez la couleur de porte du casier: ");
				string color_Door = Console.ReadLine();

                Battens bat = new Battens("Battens", 2,null ,Battens_dim );
                bat.SetDimensions(Battens_dim );
                UDpanel udpanel = new UDpanel("UDpanel", 3, color,UDpanel_dim );
                udpanel.SetDimensions(UDpanel_dim ); 
                LRpanel lrpanel = new LRpanel("LRpanel", 2, color);
                lrpanel.SetDimensions(LRpanel_dim );
                BackPanel backpanel = new BackPanel("BackPanel", 5, color,Backpannel_dim );
                backpanel.SetDimensions(Backpannel_dim );
                FBCrossbar fbcrossbar = new FBCrossbar("FBCrossbar", 1);
                fbcrossbar.SetDimensions(FBcrossbar_dim );
                LRcrossbar lrcrossbar = new LRcrossbar("LRcrossbar", 1);
                lrcrossbar.SetDimensions(LRcrossbar_dim );
                AngleBar anglebar = new AngleBar("AngleBar", 4, color);
                anglebar.SetDimensions(Battens_dim );
                Door door = new Door("Door", 5, color_Door,FBcrossbar_dim  );

                Rack rack = new Rack(bat, lrpanel, udpanel, backpanel, fbcrossbar, lrcrossbar, anglebar, door);
               

                Console.WriteLine("\ncaracteristique du casier 1 :");

                Console.WriteLine(rack.ToString() ); 

                Console.WriteLine("\nEntrez la hauteur du casier 2 :");
                int height2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("voulez vous garder les mêmes couleur que le casier 1 ? [oui/non] ");
                string condition = Console.ReadLine();

                if(condition == "non")
                {
					
					Dimensions LRpanel_dim2 = new Dimensions(height2, 0, depth);
					Dimensions Battens_dim2 = new Dimensions(height2, 0, 0);
					Dimensions Backpannel_dim2 = new Dimensions(height2, weight, 0);
					

                    Console.WriteLine("\nEntrez la couleur du casier 2: ");
                    string color2 = Console.ReadLine();
                    Console.WriteLine("\nEntrez la couleur de la porte du casier 2: ");
                    string color_Door2 = Console.ReadLine();
                    Console.WriteLine("\nLes caracteristiques du casier 2 :");
					Battens bat2 = new Battens("Battens", 2, null, Battens_dim2);
					bat.SetDimensions(Battens_dim2);
					
					LRpanel lrpanel2 = new LRpanel("LRpanel", 2, color2);
					lrpanel2.SetDimensions(LRpanel_dim2);
					BackPanel backpanel2 = new BackPanel("BackPanel", 5, color2, Backpannel_dim2);
					backpanel.SetDimensions(Backpannel_dim);
					
					
					AngleBar anglebar2 = new AngleBar("AngleBar", 4, color2);
					anglebar2.SetDimensions(Battens_dim2);
					Door door2 = new Door("Door", 5, color_Door2, FBcrossbar_dim);

					Rack rack2 = new Rack(bat2, lrpanel2, udpanel, backpanel2, fbcrossbar, lrcrossbar, anglebar2, door2);
                    Console.WriteLine(rack2.ToString());

                    Shelf shelf = new Shelf();
                    shelf.AddRack(rack);
                    shelf.AddRack(rack2);

                    Console.WriteLine("Propriétés Armoire :");
                    Console.WriteLine(shelf.ToString(1) );
                    Console.WriteLine(shelf.ToString(2));

                    Console.WriteLine("\nPour modifier un casier entez son numero: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(shelf.ToString(num));

                   

  
                }
                else 
                {
                    Console.WriteLine("\nLes caracteristiques du casier 2 :");  
                    
                }

                Console.WriteLine();  











                
            }
        }
    }
}
