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
	/// Trieda tlacidla ktore zmeni farbu ak je stlacene na urcitu dobu
	/// </summary>
	public class BlinkButton : Button
	{
		public BlinkButton() {}

		public BlinkButton(string text, ContentAlignment textAlign, DockStyle dockStyle, Font font, Color backColor)
		{
			Text = text;
			TextAlign = textAlign;
			Dock = dockStyle;
			Font = font;
			BackColor = backColor;
		}


		/// <summary>
		/// Farba pri kliknuti na tlacidlo
		/// </summary>
		public Color BlinkColor { get; set; } = Color.Blue;
		/// <summary>
		/// Interval zmeny farby pri stlaceni
		/// </summary>
		public double BlinkInterval { get; set; } = 100;
		/// <summary>
		/// Zmena podfarbenia tlacidla pri kliknuti nanho
		/// </summary>
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (this.BackColor != BlinkColor)									//ak už má farbu stlačenia tak nepokračuje
			{
				var prevColor = this.BackColor;									//preuloženie pôvodnej farby tlačidla
				BackColor = BlinkColor;
				DateTime time = DateTime.Now;
				do
				{
					Application.DoEvents();										//obluzenie eventov aplikacie aby sa UI nebolo zamrznute
				} while (time.AddMilliseconds(BlinkInterval) > DateTime.Now);
				this.BackColor = prevColor;										//nastavenie pôvodnej farby
			}
		}
	}
}
