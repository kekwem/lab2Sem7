using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceForm.ServiceReference;

namespace WCFServiceForm
{
    public partial class Form1 : Form
    {
        CalculatorSeviceClient client;

        public Form1()
        {
            client = new CalculatorSeviceClient();
            InitializeComponent();
        }

        private void dodawanieButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = client.dodawanie2Param(
                new ComplexType() { Rzeczewista = Double.Parse(rz_1.Text), Urojona = Double.Parse(ur_1.Text)},
                new ComplexType() { Rzeczewista = Double.Parse(rz_2.Text), Urojona = Double.Parse(ur_2.Text)});
        }

        private void odejmowanieButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = client.odejmowanie2Param(
                new ComplexType() { Rzeczewista = Double.Parse(rz_1.Text), Urojona = Double.Parse(ur_1.Text) },
                new ComplexType() { Rzeczewista = Double.Parse(rz_2.Text), Urojona = Double.Parse(ur_2.Text) });
        }

        private void mnozenieButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = client.mnozenie2Param(
                new ComplexType() { Rzeczewista = Double.Parse(rz_1.Text), Urojona = Double.Parse(ur_1.Text) },
                new ComplexType() { Rzeczewista = Double.Parse(rz_2.Text), Urojona = Double.Parse(ur_2.Text) });
        }

        private void dzielenieButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = client.dzielenie2Param(
                new ComplexType() { Rzeczewista = Double.Parse(rz_1.Text), Urojona = Double.Parse(ur_1.Text) },
                new ComplexType() { Rzeczewista = Double.Parse(rz_2.Text), Urojona = Double.Parse(ur_2.Text) });
        }

    }
}
