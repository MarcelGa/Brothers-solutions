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
		public Order(List<Item> items)
		{
			Items = items;
			Date = DateTime.Now;
		}
		[XmlArrayItem]
		public List<Item> Items { get; set; }
		[XmlAttribute]
		public DateTime Date { get; set; }
		[XmlIgnore]
		public decimal Price => Items.Sum(i => i.Price);
	}
}
