using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kasa
{
	/// <summary>
	/// Hlavne okno aplikacie Kasa
	/// </summary>
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			itemsCatalog.Initialize(new List<Item>()
			{
				new Item("Lokša", 1.2m, ECategory.Food),
				new Item("Mastný chl.",0.7m, ECategory.Food),
				new Item("Štrúdľa", 1.2m, ECategory.Food),
				new Item("Horálka", 0.7m, ECategory.Food),
				new Item("Pivo", 1.5m, ECategory.AlcoholDrink),
				new Item("Hubert", 9, ECategory.AlcoholDrink),
				new Item("Tvrdé", 1, ECategory.AlcoholDrink),
				new Item("Pálenka", 1, ECategory.AlcoholDrink),
				new Item("Medovina", 2, ECategory.AlcoholDrink),
				new Item("Sprite", 0.5m, ECategory.NonAlcoholDrink),
				new Item("Cola", 0.5m, ECategory.NonAlcoholDrink),
				new Item("RedBull", 2.5m, ECategory.NonAlcoholDrink),
				new Item("Minerálka", 1, ECategory.NonAlcoholDrink),
				new Item("Džús", 0.7m, ECategory.NonAlcoholDrink),
				new Item("Džús krab.", 0.6m, ECategory.NonAlcoholDrink)
			}
			);
			itemsCatalog.ItemClicked += OnCatalogItemClicked;
		}
		/// <summary>
		/// Event pri stlačení tlačidla indikátora predajnej položky
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCatalogItemClicked(object sender, EventArgs e)
		{
			var item = sender as Item;
			if (item != null)
				AddItem(item);
		}
		/// <summary>
		/// Pridanie položky do objednávky
		/// </summary>
		/// <param name="item"></param>
		private void AddItem(Item item)
		{
			dataGridViewOrder.Rows.Add(item.Title, item.Price, "x");
			dataGridViewOrder.Rows[dataGridViewOrder.Rows.Count - 1].Tag = item;
			items.Add(item);
			UpdatePrice();
		}

		/// <summary>
		/// Zoznam položiek objednávky
		/// </summary>
		private readonly List<Item> items = new List<Item>();
		/// <summary>
		/// Naformátovanie celkovej ceny objednávky
		/// </summary>
		private void UpdatePrice()
		{
			var price = items.Sum(i => i.Price);
			textBoxPrice.Text = price.ToString("N");
			calculatorMain.ComparedValue = price;													//aktualizacia porovnavanej ceny v kalkulacke
		}
		/// <summary>
		/// Event pri kliknutí na tlačidlo pre uloženie objednávky
		/// </summary>
		private void blinkButtonSaveOrder_Click(object sender, EventArgs e)
		{
			if (items.Count > 0)
			{
				var order = new Order(items);														//TODO: dokončiť uloženie objednávky

				dataGridViewOrder.Rows.Clear();
				items.Clear();
				UpdatePrice();
				calculatorMain.Clear();
			}
		}
		/// <summary>
		/// Vymazanie položky objednavky pred jej uložením kliknutím na tlačidlo pre odtránenie položky
		/// </summary>
		private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridViewOrder.Columns["ColumnRemove"].Index)					//stlpec s tlacidlom pre odstranenie polozky
			{
				var clickedRow = dataGridViewOrder.Rows[e.RowIndex];
				if (clickedRow.Tag.GetType() == typeof(Item))
				{
					var item = clickedRow.Tag as Item;
					if (item != null)
					{
						dataGridViewOrder.Rows.Remove(clickedRow);
						items.Remove(item);
						UpdatePrice();
					}
				}
			}		
		}
	}
}
