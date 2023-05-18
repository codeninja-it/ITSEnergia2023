namespace SestaApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalcola_Click(object sender, EventArgs e)
		{
			double peso = (double)numPeso.Value;
			double altezza = (double)(numAltezza.Value / 100);
			double BMI = peso / (altezza * altezza);
			txtRisultato.Text = BMI.ToString("F2");
			prgBMI.Value = (int)BMI;
		}
	}
}