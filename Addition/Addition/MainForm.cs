﻿/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 22.03.2019
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
//test
namespace Addition
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
			int sum2 = sum(2,1);
		}
		
		public int sum(int first, int second) 
		{
			int sum = first + second;
			label1.Text = sum.ToString();
			Version v = Assembly.GetExecutingAssembly().GetName().Version;
			label2.Text = v.ToString();
			return sum;
		}
	}
}
