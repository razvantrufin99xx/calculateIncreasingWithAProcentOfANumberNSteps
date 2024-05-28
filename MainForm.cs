/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/28/2024
 * Time: 11:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace increasingByProcentage
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		public void calculeaza(double i, double p, double s, ref TextBox txtr)
		{
			double procent = p / 100;
			txtr.Text += "\r\n";
			txtr.Text += "Procent  = "  + p.ToString() + " %"; 
			txtr.Text += "\r\n";
			txtr.Text += "Initial value is  = " + i.ToString();
			txtr.Text += "\r\n";
			txtr.Text += "Steps = " + s.ToString()  ;
			txtr.Text += "\r\n";
			double newValue  = i;
			for(int j = 0 ; j < s; j++){
				newValue = (newValue * procent) + newValue;
				txtr.Text +=" New value is = " +newValue.ToString() + " at step : " + (j+1).ToString() ;
				txtr.Text += "\r\n";
		
			}
			
		}
		
		public double textbox2double(ref TextBox t)
		{
			try
			{
				return double.Parse(t.Text);
			}
			catch{};
			return -1;
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			double  initval = textbox2double(ref textBox2);
			double procent = textbox2double(ref textBox3);
			double steps = textbox2double(ref textBox4);
			
			calculeaza(initval, procent, steps, ref txtRespons);
		}
	}
}


/*
 
Procent  = 100 %
Initial value is  = 5
Steps = 20
 New value is = 10 at step : 1
 New value is = 20 at step : 2
 New value is = 40 at step : 3
 New value is = 80 at step : 4
 New value is = 160 at step : 5
 New value is = 320 at step : 6
 New value is = 640 at step : 7
 New value is = 1280 at step : 8
 New value is = 2560 at step : 9
 New value is = 5120 at step : 10
 New value is = 10240 at step : 11
 New value is = 20480 at step : 12
 New value is = 40960 at step : 13
 New value is = 81920 at step : 14
 New value is = 163840 at step : 15
 New value is = 327680 at step : 16
 New value is = 655360 at step : 17
 New value is = 1310720 at step : 18
 New value is = 2621440 at step : 19
 New value is = 5242880 at step : 20


Procent  = 10 %
Initial value is  = 5
Steps = 20
 New value is = 5.5 at step : 1
 New value is = 6.05 at step : 2
 New value is = 6.655 at step : 3
 New value is = 7.3205 at step : 4
 New value is = 8.05255 at step : 5
 New value is = 8.857805 at step : 6
 New value is = 9.7435855 at step : 7
 New value is = 10.71794405 at step : 8
 New value is = 11.789738455 at step : 9
 New value is = 12.9687123005 at step : 10
 New value is = 14.26558353055 at step : 11
 New value is = 15.692141883605 at step : 12
 New value is = 17.2613560719655 at step : 13
 New value is = 18.987491679162 at step : 14
 New value is = 20.8862408470783 at step : 15
 New value is = 22.9748649317861 at step : 16
 New value is = 25.2723514249647 at step : 17
 New value is = 27.7995865674612 at step : 18
 New value is = 30.5795452242073 at step : 19
 New value is = 33.637499746628 at step : 20

 */