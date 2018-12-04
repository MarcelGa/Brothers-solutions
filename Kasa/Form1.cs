using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
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

		private void OnCatalogItemClicked(object sender, EventArgs e)
		{
			var item = sender as Item;
			if (item != null)
				AddItem(item);
		}

		private void AddItem(Item item)
		{
			dataGridViewOrder.Rows.Add(item.Title, item.Price,"x");
			items.Add(item);
			UpdatePrice();
		}
		private readonly List<Item> items = new List<Item>();

		private void UpdatePrice()
		{
			var price = items.Sum(i => i.Price);

			textBoxPrice.Text = price.ToString();

			calculatorMain.ComparedValue = price;
		}

		private void blinkButtonSaveOrder_Click(object sender, EventArgs e)
		{
			if (items.Count > 0)
			{
				var order = new Order(items);

				dataGridViewOrder.Rows.Clear();
				items.Clear();
				UpdatePrice();
				calculatorMain.Clear();
			}
		}
	}
}
