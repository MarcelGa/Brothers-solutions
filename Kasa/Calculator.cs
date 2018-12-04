using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
	public class Calculator : TableLayoutPanel
	{
		public Calculator()
		{
			InitLayout();
		}
		float DisplayHeight = 100f;
		protected override void OnLayout(LayoutEventArgs levent)
		{
			Controls.Clear();
			RowStyles.Clear();
			ColumnStyles.Clear();

			ColumnCount = 3;
			RowCount = 6;

			RowStyles.Add(new RowStyle(SizeType.AutoSize, DisplayHeight));
			for (int i = 0; i < RowCount-1 ; i++)
				RowStyles.Add(new RowStyle(SizeType.Percent, 100/RowCount));

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

			int n = 1;
			for (int i = 0; i < 3; i++)
			{
				ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
				for (int j = 0; j < 3; j++)
				{
					var btn = new BlinkButton()
					{
						Text = n.ToString(), Dock = DockStyle.Fill,
						TextAlign = ContentAlignment.MiddleCenter,
						Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
						BackColor = Color.PowderBlue
					};
					btn.Click += OnNumberClick;
					Controls.Add(btn, j, 4 - i);
					n++;
				}
			}
			var btn10 = new BlinkButton()
			{
				Text = (10).ToString(), TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
				BackColor = Color.LightSkyBlue
			};
			var btn20 = new BlinkButton()
			{
				Text = (20).ToString(), TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
				BackColor = Color.LightSkyBlue
			};
			var btn50 = new BlinkButton()
			{
				Text = (50).ToString(), TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
				BackColor = Color.LightSkyBlue
			};

			btn10.Click += OnNumberClick;
			btn20.Click += OnNumberClick;
			btn50.Click += OnNumberClick;

			Controls.Add(btn10, 0, 1);
			Controls.Add(btn20, 1, 1);
			Controls.Add(btn50, 2, 1);
			
			ValueIndicator = new TextBox()
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

		private TextBox ValueIndicator;

		private void Format()
		{
			ValueIndicator.Text = Value.ToString() + " (" + (Value - comparedValue).ToString() + ")";
		}

		private readonly List<int> Values = new List<int>();

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

		public decimal ComparedValue
		{
			get => comparedValue;
			set
			{
				comparedValue = value;
				Format();
			}
		}
		private decimal comparedValue;

		private void Add(int value)
		{
			Values.Add(value);
			Value = Values.Sum();
		}
		private void Back()
		{
			if (Values.Count > 0)
			{
				Values.RemoveAt(Values.Count - 1);
				Value = Values.Sum();
			}
		}
		public void Clear()
		{
			Values.Clear();
			Value = 0;
		}

		private void OnNumberClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
			{
				Add(Convert.ToInt32(btn.Text));
			}
		}
		private void OnBackClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
			{
				Back();
			}
		}
		private void OnClearClick(object sender, EventArgs e)
		{
			var btn = sender as BlinkButton;
			if (btn != null)
			{
				Clear();
			}
		}
	}
}
