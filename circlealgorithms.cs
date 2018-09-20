//Made by Lucas Vinyard
//
//

using System;
using System.Drawing;
using System.Windows.Forms;

public class Circlealgorithms {
	 public static Rectangle getinformation(int uiwidth, int uiheight, int rad){
		 
        //Get Center of Form
		 Point corner = new Point(uiwidth/2-rad,uiheight/2-rad);
		 Size widhigh = new Size(2*rad,2*rad);

        //Make Rectangtle
		 Rectangle rect = new Rectangle(corner,widhigh);
		 return rect;
		 }//End of Fuction getinformation
		 
}//End of Class Circlealgorithsm
