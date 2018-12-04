using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
	/// <summary>
	/// Trieda indikatora polozky
	/// </summary>
	public class ItemIndicator : BlinkButton
	{
		public ItemIndicator(Item item)
		{
			this.BackColor = System.Drawing.Color.Azure;
			this.FlatStyle = FlatStyle.Popup;
			this.Text = item.Title + " (" + item.Price + " Eur)";
			this.Dock = DockStyle.Fill;
			Item = item;
		}

		public readonly Item Item;
	}
}
