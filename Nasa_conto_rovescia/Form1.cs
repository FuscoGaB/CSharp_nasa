namespace Nasa_conto_rovescia
{
    public partial class Form1 : Form
    {
        private bool houstonPronto = false;
        private bool capePronto = false;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button_houston_Click(object sender, EventArgs e)
        {
            Thread threadHouston = new Thread(() => ContaAllaRovescia("Houston"));
            threadHouston.Start();
        }

        private void button_cape_Click(object sender, EventArgs e)
        {
            Thread threadCape = new Thread(() => ContaAllaRovescia("Cape Canaveral"));
            threadCape.Start();
        }
        private void ContaAllaRovescia(string centro)
        {
            for (int i = 10; i > 0; i--)
            {
                if (centro == "Houston")
                {
                        labelHouston.Text = $"Houston: {i} secondi...";
                }
                else if (centro == "Cape Canaveral")
                {
                        labelCape.Text = $"Cape Canaveral: {i} secondi...";
                }
                Thread.Sleep(1000);
            }

            if (centro == "Houston")
            {
                    houstonPronto = true;
                    labelHouston.Text = "Houston è pronto!";
            }
            else if (centro == "Cape Canaveral")
            {
                    capePronto = true;
                    labelCape.Text = "Cape Canaveral è pronto!";
            }
            ControllaLancio();
        }
        private void ControllaLancio()
        {
            if (houstonPronto && capePronto)
            {
                    labelStatus.Text = "Stato: Razzo lanciato!";
                    MessageBox.Show("Il razzo è stato lanciato con successo!");
            }
        }
    }
}
