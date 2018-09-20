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
 *  Specifics: This file holds the main function which calls for the object ui of Program class to be ran.
 *  
 *  
 */

using System;
using System.Drawing;
using System.Windows.Forms;

public class driver{
	
	static void Main(){
	
	System.Console.WriteLine("Welcome Assignment 1 - By Lucas Vinyard");
	Program ui = new Program();
	Application.Run(ui);
	System.Console.WriteLine("Assignment 1 Finished");
	
	}//end main
	
}//end driver
