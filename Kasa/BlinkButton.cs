using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Kasa
{
	/// <summary>
	/// trieda tlacidla ktore zmeni farbu ak je stlacene na urcitu dobu
	/// </summary>
	public class BlinkButton : Button
	{
		/// <summary>
		/// Farba pri kliknuti na tlacidlo
		/// </summary>
		public Color BlinkColor { get; set; } = Color.Blue;
		/// <summary>
		/// interval zmeny farby pri stlaceni
		/// </summary>
		public double BlinkInterval { get; set; } = 100;

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (this.BackColor != BlinkColor)
			{
				var prevColor = this.BackColor;
				this.BackColor = BlinkColor;
				DateTime Tthen = DateTime.Now;
				do
				{
					Application.DoEvents();
				} while (Tthen.AddMilliseconds(BlinkInterval) > DateTime.Now);
				this.BackColor = prevColor;
			}
		}
	}
}
