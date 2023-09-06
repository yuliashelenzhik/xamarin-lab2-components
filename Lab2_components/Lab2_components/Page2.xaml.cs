using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab2_components
{	
	public partial class Page2 : ContentPage
	{	
		public Page2 (string data)
		{
			InitializeComponent ();
            Label1.Text = data;
        }
	}
}

