namespace Calculadora;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void BtSomar_Clicked(object sender, EventArgs e)
    {
        Double valor1 = Convert.ToDouble(etValor1.Text);
        Double valor2 = Convert.ToDouble(etValor2.Text);
        double total = valor1 + valor2;
        DisplayAlert("Alert", "Total: " + valor1 + " + " + valor2 + " = " + total, "OK");

    }

    private void BtSubtrair_Clicked(object sender, EventArgs e)
    {
        Double valor1 = Convert.ToDouble(etValor1.Text);
        Double valor2 = Convert.ToDouble(etValor2.Text);
        double total = valor1 - valor2;
        DisplayAlert("Alert", "Total: " + valor1 + " - " + valor2 + " = " + total, "OK");
    }

    private void BtDividir_Clicked(object sender, EventArgs e)
    {
        Double valor1 = Convert.ToDouble(etValor1.Text);
        Double valor2 = Convert.ToDouble(etValor2.Text);
        double total = valor1 / valor2;
        DisplayAlert("Alert", "Total: " + valor1 + " / " + valor2 + " = " + total, "OK");
    }

    private void BtDividirResto_Clicked(object sender, EventArgs e)
    {
        int valor1 = Convert.ToInt32(etValor1.Text);
        int valor2 = Convert.ToInt32(etValor2.Text);
        double total = valor1 - valor2;
        DisplayAlert("Alert", "Total: " + valor1 + " - " + valor2 + " = " + total, "OK");
    }

    private void BtMultiplicar_Clicked(object sender, EventArgs e)
    {
        Double valor1 = Convert.ToDouble(etValor1.Text);
        Double valor2 = Convert.ToDouble(etValor2.Text);
        double total = valor1 * valor2;
        DisplayAlert("Alert", "Total: " + valor1 + " * " + valor2 + " = " + total, "OK");
    }
}

