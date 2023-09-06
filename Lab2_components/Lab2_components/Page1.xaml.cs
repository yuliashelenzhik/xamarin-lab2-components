using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab2_components
{	
	public partial class Page1 : ContentPage
	{	
		public Page1 (string data)
		{
			InitializeComponent ();

            Label1.Text = data;
        }
	}
}

