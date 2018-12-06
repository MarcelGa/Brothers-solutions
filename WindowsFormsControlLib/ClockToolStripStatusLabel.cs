using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsControlLib
{
	/// <summary>
	/// Trieda ukazovatela aktualneho casu v StatusStrip-e
	/// </summary>
	public class ClockToolStripStatusLabel : ToolStripStatusLabel
	{
		/// <summary>
		/// Povolenie zobrazenia aj sekund 
		/// </summary>
		[
		Category("Format"),
		Description("Enable seconds digits.")
		]
		public bool ShowSeconds
		{
			get => showSeconds;
			set
			{
				showSeconds = value;
				Format = value ? "HH:mm:ss" : "HH:mm";
			}
		}
		private bool showSeconds = true;
		/// <summary>
		/// Formát zobrazenia času
		/// </summary>
		private string Format = "HH:mm";

		/// <summary>
		/// Naformatovanie textu indikátora času
		/// </summary>
		private void FormatText()
		{
			Text = DateTime.Now.ToString(Format);
		}
		/// <summary>
		/// event pri spusteni aplikacii
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLayout(LayoutEventArgs e)
		{
			base.OnLayout(e);

			FormatText();										//prve nastavenie
			var timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += OnTimerIntervalElapsed;
			timer.Start();
		}
		/// <summary>
		/// Event pri dovrseni intervalu timer-a
		/// </summary>
		private void OnTimerIntervalElapsed(object source, EventArgs e)
		{
			FormatText();
		}
	}
}
