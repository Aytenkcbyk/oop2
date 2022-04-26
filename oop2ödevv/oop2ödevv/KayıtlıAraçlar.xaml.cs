using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace oop2ödevv
{	
	public partial class KayıtlıAraçlar : ContentPage
	{	
		public KayıtlıAraçlar ()
		{
			InitializeComponent ();
		}
		public void btnYeniAraçKayıt_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new AraçTipi());


		}

	}
}

