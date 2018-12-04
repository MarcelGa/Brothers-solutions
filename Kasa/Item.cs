using System;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
	/*public class Drink : Item
	{
		public Drink()
		{

		}
	}*/

	/// <summary>
	/// Trieda polozky kasi
	/// </summary>
	public class Item:IComparable<Item>
	{

		public Item(string title, decimal price, ECategory category)
		{
			Title = title;
			Price = price;
			Category = category;
		}
		/// <summary>
		/// Cena polozky
		/// </summary>
		[XmlAttribute]
		public decimal Price { get; set; } = 0;
		/// <summary>
		/// Nazov polozky
		/// </summary>
		[XmlAttribute]
		public string Title { get; set; } = "N/A";
		/// <summary>
		/// Kategoria polozky
		/// </summary>
		[XmlAttribute]
		public ECategory Category { get; set; } = ECategory.AlcoholDrink;
		/// <summary>
		/// Zoradenie podla Title abecetdne
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(Item other)
		{
			return String.Compare(this.Title, other.Title, true);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Title;
		}
	}
	/// <summary>
	/// Enumerator kategoria polozky
	/// </summary>
	public enum ECategory
	{
		Food = 1,
		AlcoholDrink = 2,
		NonAlcoholDrink = 3
	}
}