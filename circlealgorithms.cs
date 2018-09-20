/* To draw Circles Made by Lucas Vinyard
 * 
 *  Current files: ui.cs, driver.cs, circlealgorthms.cs
 *
 *  Project state: Fully functional
 *  
 *  Notes: The circle radi of 200, 400, and 600 did not fit on form
 *          so, I had to change the scale by 1/2. The current radi 
 *          implemented are 100, 200, and 300.
 *  
 *  To compile: Use the build script included, build.sh , which takes advantage of the Mono compiler. 
 *              Using the Command Prompt, Chnage directory to where code is stored and run the build.sh
 *  
 *  
 *  Specifics: This file covers the computations of creating the limits of where a circle should be created, given its radius.
 *
 */

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
