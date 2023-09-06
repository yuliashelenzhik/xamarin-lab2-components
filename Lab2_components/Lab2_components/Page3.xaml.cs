using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lab2_components
{	
	public partial class Page3 : ContentPage
	{	
		public Page3 (string data)
		{
			InitializeComponent ();
            Label1.Text = data;
        }
	}
}

