using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;

namespace Kasa
{
	/// <summary>
	/// Trieda objednavky
	/// </summary>
	public class Order
	{
		public Order(){}
		/// <summary>
		/// Konštruktor objektu
		/// </summary>
		/// <param name="items"></param>
		public Order(List<Item> items)
		{
			Items = items;
			Date = DateTime.Now;
		}
		/// <summary>
		/// Zoznam položiek objednávky
		/// </summary>
		[XmlArrayItem]
		public List<Item> Items { get; set; }
		/// <summary>
		///Dátum uzavretia objednávky
		/// </summary>
		[XmlAttribute]
		public DateTime Date { get; set; }
		/// <summary>
		/// Výsledná cena objednávky
		/// </summary>
		[XmlIgnore]
		public decimal Price => Items.Sum(i => i.Price);
	}
}
