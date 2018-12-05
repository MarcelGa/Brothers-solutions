using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Kasa
{
	/// <summary>
	/// Trieda zobrazovaca poloziky ako katalog
	/// </summary>
	public class ItemsCatalog : TableLayoutPanel
	{
		/// <summary>
		/// Velkost polozky
		/// </summary>
		private const float rowHeight = 100f;
		/// <summary>
		/// velkost fontu poloziek
		/// </summary>
		private const float fontSize = 18f;

		/// <summary>
		/// Funkcia pre inizializaciu poloziek katalogu
		/// </summary>
		/// <param name="items"></param>
		public void Initialize(List<Item> items)
		{
			var itemsByCategory = (items.GroupBy(i => i.Category).Select(i => new
			{
				Category = i.Key,
				Items = i.Select(x => x).ToList()
			})).ToList();
			ColumnCount = itemsByCategory.Count();

			ColumnStyles.Clear();
			foreach (var item in itemsByCategory)
			{
				item.Items.Sort();
				AddIndicators(item.Items, itemsByCategory.IndexOf(item));
				ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
			}

			RowStyles.Clear();
			for (int i = 0; i < RowCount; i++)
				RowStyles.Add(new RowStyle(SizeType.Absolute, rowHeight));

			RowCount = RowCount + 1;        //pridanie riadku na koniec zoznamu aby vsetky ostatne riadky mali fixnu velkost
		}
		/// <summary>
		/// funkcia ktora prida polozky do stlpca
		/// </summary>
		/// <param name="items"></param>
		/// <param name="colIdx"></param>
		private void AddIndicators(IEnumerable<Item> items, int colIdx)
		{
			if (RowCount < items.Count())
				RowCount = items.Count();

			int rowIdx = 0;
			foreach (var item in items)
			{
				var indicator = new ItemIndicator(item)
				{
					Font = new Font(Font.FontFamily, fontSize, FontStyle.Bold)
				};
				indicator.Click += ItemClick;

				Controls.Add(indicator, colIdx, rowIdx);
				rowIdx++;
			}
		}
		/// <summary>
		/// Event pri kliknuti na predajnu polozku
		/// </summary>
		public event EventHandler ItemClicked;
		/// <summary>
		///Event pri kliku na tlacidlo indikatora predajnej polozky 
		/// </summary>
		/// <param name="item"></param>
		/// <param name="e"></param>
		protected virtual void OnItemClicked(Item item, EventArgs e)
		{
			var handler = ItemClicked;
			if (handler != null)
				handler(item, e);
		}
		/// <summary>
		/// Event pri kliknuti na polozku katalogu
		/// </summary>
		private void ItemClick(object sender, EventArgs e)
		{
			var indicator = sender as ItemIndicator;
			if (indicator != null)
			{
				OnItemClicked(indicator.Item, EventArgs.Empty);
			}
		}
	}
}
