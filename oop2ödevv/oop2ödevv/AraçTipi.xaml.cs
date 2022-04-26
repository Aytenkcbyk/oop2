using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace oop2ödevv
{	
	public partial class AraçTipi : ContentPage
	{	
		public AraçTipi ()
		{
			InitializeComponent ();
		}
		public void btnOtomobil_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Otomobil());


		}
		public void btnMinibüs_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Minibüs());


		}

	}

}