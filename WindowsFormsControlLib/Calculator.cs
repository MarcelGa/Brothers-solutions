using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
	/// <summary>
	/// Kalkulačka pre výpočet vrátenej sumy ako rozdiel zadanej obdržanej finančnej čiastky a ceny objednávky
	/// </summary>
	public class Calculator : TableLayoutPanel
	{
		/// <summary>
		/// Farba čísiel 1 - 9
		/// </summary>
		public Color DigitsColor { get; set; } = Color.PowderBlue;
		/// <summary>
		/// Farba špeciálnych číselných tlačidiel
		/// </summary>
		public Color CustomDigitsColor { get; set; } = Color.LightSkyBlue;
		/// <summary>
		/// Špecíalne tlačidlá
		/// </summary>
		public List<int> CustomDigits = new List<int> {10, 20, 50};

		public Calculator()
		{
			InitLayout();
		}
		/// <summary>
		/// Veľkosť displeja kalkulačky
		/// </summary>
		float DisplayHeight = 100f;
		/// <summary>
		/// Inicializácia layoutu kalkulačky
		/// </summary>
		protected override void OnLayout(LayoutEventArgs levent)
		{
			Controls.Clear();
			RowStyles.Clear();
			ColumnStyles.Clear();

			ColumnCount = 3;
			RowCount = 6;

			RowStyles.Add(new RowStyle(SizeType.AutoSize, DisplayHeight));			//prvý riadok je displej
			for (int i = 0; i < RowCount-1 ; i++)
				RowStyles.Add(new RowStyle(SizeType.Percent, 100/RowCount));		//ostatné riadky sú rovnako vysoké tlačidlá

			for (int i = 0; i < ColumnCount; i++)
				ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));

			var btnBack = new BlinkButton()
			{
				Text = "Späť", Dock = DockStyle.Fill,
				Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
				BackColor = Color.PapayaWhip
			};
			btnBack.Click += OnBackClick;
			Controls.Add(btnBack, 0, 5);
			SetColumnSpan(btnBack, 2);

			var btnClear = new BlinkButton()
			{
				Text = "0", Dock  = DockStyle.Fill,
				Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
				BackColor = Color.Red
			};
			btnClear.Click += OnClearClick;
			Controls.Add(btnClear, 2, 5);

			int n = 1;																//premenna pre text ciselnika kalkulacky
			for (int i = 0; i < 3; i++)
			{
				ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
				for (int j = 0; j < 3; j++)
				{
					var btn = new BlinkButton(n.ToString(), ContentAlignment.MiddleCenter, DockStyle.Fill, new Font(Font.FontFamily, 15, FontStyle.Bold), DigitsColor);
					btn.Click += OnNumberClick;
					Controls.Add(btn, j, 4 - i);
					n++;
				}
			}

			foreach(var customDigit in CustomDigits)
			{
				var customBtn = new BlinkButton(customDigit.ToString(), ContentAlignment.MiddleCenter, DockStyle.Fill, new Font(Font.FontFamily, 15, FontStyle.Bold), CustomDigitsColor);
				customBtn.Click += OnNumberClick;
				Controls.Add(customBtn, CustomDigits.IndexOf(customDigit),1);
			}
			
			ValueIndicator = new TextBox()										//displej
			{
				Text = "0",
				TextAlign = HorizontalAlignment.Center,
				Dock = DockStyle.Fill,
				ReadOnly = true,
				Font = new Font(Font.FontFamily,DisplayHeight, FontStyle.Bold, GraphicsUnit.Pixel)
			};
			Controls.Add(ValueIndicator, 0, 0);
			SetColumnSpan(ValueIndicator, 3);

			base.OnLayout(levent);
		}
		/// <summary>
		/// Displej pre indikáciu hodnoty kalkulačky
		/// </summary>
		private TextBox ValueIndicator;

		/// <summary>
		/// Funkcia pre naformatovanie Textu v displeji
		/// </summary>
		private void Format()
		{
			ValueIndicator.Text = Value.ToString() + " (" + (Value - _comparedValue).ToString() + ")";
		}
		/// <summary>
		/// Zadane hodnoty do kalkulačky od posledného zmazania
		/// </summary>
		private readonly List<int> Values = new List<int>();

		/// <summary>
		/// Zadaná hodnota tlačidlami kalkulačky
		/// </summary>
		int Value
		{
			get => _value; 
			set
			{
				_value = value;
				Format();
			}
		}
		int _value;

		/// <summary>
		/// Porovnávaná hodnota (obdržaná finančná čiastka)
		/// </summary>
		public decimal ComparedValue
		{
			get => _comparedValue;
			set
			{
				_comparedValue = value;
				Format();
			}
		}
		private decimal _comparedValue;

		/// <summary>
		/// Funkcia pre pripočítanie zadanej hodnoty k predchádzajúcim zadaným hodnotám tlačidlami kalkulačky
		/// </summary>
		/// <param name="value"></param>
		private void Add(int value)
		{
			Values.Add(value);
			Value = Values.Sum();
		}
		/// <summary>
		/// Funkcia pre odpočítanie poslednej zadanej hodnoty od hodnoty zobrazenej v kalkulačke
		/// </summary>
		private void Back()
		{
			if (Values.Count > 0)
			{
				Values.RemoveAt(Values.Count - 1);
				Value = Values.Sum();
			}
		}
		/// <summary>
		/// Funkcia pre vynulovanie zadaných hodnôt kalkulačky
		/// </summary>
		public void Clear()
		{
			Values.Clear();					//vynulovanie zoznamu zadaných hodnôt
			Value = 0;						//vynulovanie aktuálnej hodnoty
		}
		/// <summary>
		/// Event pri stlačení hodnotového tlačidla kalkulačky
		/// </summary>
		private void OnNumberClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
				Add(Convert.ToInt32(btn.Text));
		}
		/// <summary>
		/// Event pri stlačení tlačidla pre odpočítanie poslednej zadanej hodnoty od hodnoty zobrazenej v kalkulačke
		/// </summary>
		private void OnBackClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
				Back();
		}
		/// <summary>
		/// Event pri sltačení tlačidla pre vynulovanie zadaných hodnôt kalkulačky
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnClearClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
				Clear();
		}
	}
}
