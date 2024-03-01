namespace AS2324_3F_Prof_Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            double risultato=0;

            double operando1 = Convert.ToDouble(txtOperando1.Text);
            double operando2 = Convert.ToDouble(txtOperando2.Text);

            switch (cmbOperatore.Text)
            {
                case "+":
                    risultato  = operando1 + operando2;
                    break;
                case "-":
                    risultato  = operando1 - operando2;
                    break;
                case "*":
                    risultato  = operando1 * operando2;
                    break;
                case "/":
                    risultato  = operando1 / operando2;
                    break;
            }

            lblRisultato.Text = "Risultato " + risultato.ToString();
        }
    }
}
