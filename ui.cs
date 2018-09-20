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
 *  Specifics: This file holds most of the code, which handles the ui of the program.
 * Test
 */
using System;
using System.Drawing;
using System.Windows.Forms;


public class Program: Form {

//Making font for Name and Project name
	private Font arial = new Font("Arial", 24, FontStyle.Bold);

    //Making Pens 
    Pen blackPen = new Pen(Color.Black);
	 Pen circlePen = new Pen(Color.Gray);

//Circle Variables
		Color color200= Color.Gray;
		Color color400 = Color.Gray;
		Color color600 = Color.Gray;
		Color c = Color.Gray;
		int radius = 200;	 

//Functions that are called when Buttons are pressed.
		protected void Greenfunction(Object x,EventArgs e)
		{
        c = Color.Green;
		}
		
	    protected void Redfunction(Object x, EventArgs e)
	    {
        c = Color.Red;
		}
		
		protected void Bluefunction(Object x,EventArgs e)
		{
        c = Color.Blue;
		}  
		
		protected void Rad200(Object x, EventArgs e)
		{
        radius =200;
		}
		
		protected void Rad400(Object x, EventArgs e)
		{
        radius =400;
		}
		
		protected void Rad600(Object x, EventArgs e)
		{
        radius =600;
		}
		
		protected void Drawfunction(Object x, EventArgs e)
		{
				switch(radius)
				{	case 200: color200 = c;
						break;
					case 400: color400 = c;
						break;
					case 600: color600= c;
						break;
				}
				Invalidate();
			}
		
		protected void Clearfunction(Object x, EventArgs e)
		{
         color200 = Color.Gray;
		 color400 = Color.Gray;
		 color600 = Color.Gray;
		 Invalidate();
		}

        protected void Quitfunction(Object x, EventArgs e)
        {
          Application.Exit();
        }

//	
//Makes Boxes for Controls and Event Handlers (To be called in Constuctor)	
//
	private void InitializeMyGroupBox()
{
// Create and initialize a GroupBox and a Button control.
            GroupBox  color = new GroupBox();
            color.ForeColor = Color.Black;
            color.Text = "Choose a Color";
            color.Location = new Point(100,820);
            
     //Create "Red" Button in Selete color box       
            Button redButton = new Button();
            redButton.Location = new Point(10,20);
            redButton.Font = new Font("Arial", 10, FontStyle.Bold);
            redButton.ForeColor = Color.Red;
            redButton.Text="Red";
            redButton.BackColor = Color.Black;
			redButton.Click += new EventHandler(Redfunction);
			
            // Add the "Red" Button to the GroupBox.
            color.Controls.Add(redButton);
            
     //Create "Green" Button in Select Color box      
            Button greenButton = new Button();
            greenButton.Location = new Point(10,45);
            greenButton.Font = new Font("Arial", 10, FontStyle.Bold);
            greenButton.ForeColor = Color.Green;
            greenButton.Text="Green";
            greenButton.BackColor = Color.Black;
            greenButton.Click += new EventHandler(Greenfunction);

            // Add the "Green" Button to the GroupBox.
            color.Controls.Add(greenButton);
            
	//Add "Blue Button in Select color box
			Button blueButton = new Button();
            blueButton.Location = new Point(10,70);
            blueButton.Font = new Font("Arial", 10, FontStyle.Bold);
            blueButton.ForeColor = Color.Blue;
            blueButton.Text="Blue";
            blueButton.BackColor = Color.Black;
            blueButton.Click += new EventHandler(Bluefunction);

            // Add the Button to the GroupBox.
            color.Controls.Add(blueButton);
            
            // Add the GroupBox to the Form.
            Controls.Add(color);
            
            

 // Create and initialize a GroupBox and a Button control.
            GroupBox  radius = new GroupBox();
            radius.ForeColor = Color.Black;
            //color.BackColor = Color.Yellow
            radius.Text = "Choose a Radius";
            radius.Location = new Point(400,820);
            
     //Create "200" Button in Selete color box       
            Button twoButton = new Button();
            twoButton.Location = new Point(10,20);
            twoButton.Font = new Font("Arial", 10, FontStyle.Bold);
            twoButton.ForeColor = Color.White;
            twoButton.Text="100";
            twoButton.BackColor = Color.Black;
            twoButton.Click += new EventHandler(Rad200);
			
            // Add the "Red" Button to the GroupBox.
            radius.Controls.Add(twoButton);
            
     //Create "400" Button in Select Color box      
            Button fourButton = new Button();
            fourButton.Location = new Point(10,45);
            fourButton.Font = new Font("Arial", 10, FontStyle.Bold);
            fourButton.ForeColor = Color.White;
            fourButton.Text="200";
            fourButton.BackColor = Color.Black;
            fourButton.Click += new EventHandler(Rad400);

            // Add the "Green" Button to the GroupBox.
            radius.Controls.Add(fourButton);
            
	//Add "600" Button in Select color box
			Button sixButton = new Button();
            sixButton.Location = new Point(10,70);
            sixButton.Font = new Font("Arial", 10, FontStyle.Bold);
			sixButton.ForeColor = Color.White;
            sixButton.Text="300";
            sixButton.BackColor = Color.Black;
            sixButton.Click += new EventHandler(Rad600);

            // Add the Button to the GroupBox.
            radius.Controls.Add(sixButton);
            
            // Add the GroupBox to the Form.
            Controls.Add(radius);
            
            
 // Create and initialize a GroupBox and a Button control.
            GroupBox  action = new GroupBox();
            action.ForeColor = Color.Black;
            //color.BackColor = Color.Yellow
            action.Text = "Choose an Action";
            action.Location = new Point(700,820);
            
     //Create "clear" Button in Selete color box       
            Button clearButton = new Button();
            clearButton.Location = new Point(10,20);
            clearButton.Font = new Font("Arial", 10, FontStyle.Bold);
            clearButton.ForeColor = Color.Yellow;
            clearButton.Text="Clear";
            clearButton.BackColor = Color.Black;
            clearButton.Click += new EventHandler(Clearfunction);

            // Add the "Red" Button to the GroupBox.
            action.Controls.Add(clearButton);
            
     //Create "draw" Button in Select Color box      
            Button drawButton = new Button();
            drawButton.Location = new Point(10,45);
            drawButton.Font = new Font("Arial", 10, FontStyle.Bold);
			drawButton.ForeColor = Color.Green;
            drawButton.Text="Draw";
            drawButton.BackColor = Color.Black;
            drawButton.Click += new EventHandler(Drawfunction);

            // Add the "Green" Button to the GroupBox.
            action.Controls.Add(drawButton);
            
	 //Add "quit" Button in Select color box
			Button quitButton = new Button();
            quitButton.Location = new Point(10,70);
            quitButton.Font = new Font("Arial", 10, FontStyle.Bold);
            quitButton.ForeColor = Color.Red;
            quitButton.Text="Quit";
            quitButton.BackColor = Color.Black;
        quitButton.Click += new EventHandler(Quitfunction);

            // Add the Button to the GroupBox.
            action.Controls.Add(quitButton);
            
            // Add the GroupBox to the Form.
            Controls.Add(action);
}//End of GroupBox controls




//	 
//Constructor
//
	public Program(){
	
//Setting Window Properties
	Size = new Size(1000,1000);
	Text = "Assignment 1 - By Lucas Vinyard";
	BackColor=Color.Gray;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;


        //Making title 
        Label nameLabel = new Label();
	nameLabel.Text = "To Draw Circles by Lucas Vinyard";
        nameLabel.AutoSize = false;
    nameLabel.TextAlign = ContentAlignment.MiddleCenter;
        nameLabel.Font = arial;
	nameLabel.Height = 40;
	nameLabel.Width = 1000;
	Controls.Add(nameLabel);
	

//Calls group Box function for Button Interface
	InitializeMyGroupBox();
	
}//End of Construct
	
	
	
//On Paint
	protected override void OnPaint(PaintEventArgs e) {
		
		Graphics g = e.Graphics;
		
		//Draw Pen (Line across bottom screen)
		blackPen.Width = 5;
		g.DrawLine(blackPen,0,800,1000,800);
		
		//Draw Rectangle (Black box on bottom screen)
		g.FillRectangle(Brushes.White,0,800,1000,800);
		
		//Drawing Circles
		circlePen.Width = 5;
		
		circlePen.Color = color200;
		Rectangle info = Circlealgorithms.getinformation(1000,800,100);
		g.DrawEllipse(circlePen,info);
		
		circlePen.Color = color400;
		info = Circlealgorithms.getinformation(1000,800,200);
		g.DrawEllipse(circlePen,info);
		
		circlePen.Color = color600;
		info = Circlealgorithms.getinformation(1000,800,300);
		g.DrawEllipse(circlePen,info);
		
		base.OnPaint(e);
	}// End of OnPaint
	

	
}// End of Class
