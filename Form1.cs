using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dieselPrice = 53.43; // Fiyatları API den çekmek için sıfırladık.
        double gasolinePrice = 51.11;
        double lpg = 25.46;
        double gasAmount=0;
        double dieselAmount=0;
        double lpgAmount=0;
        double progressBarValue;
        double totalPrice = 0;
        int count = 0; // kontrol degiskeni
        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtGasAmount.Text);
            dieselAmount = Convert.ToDouble(txtGasAmount.Text);
            lpgAmount = Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 250;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

               
            if(rdbGasoline.Checked) // benzin seçildiyse ve miktar da girildiyse gasAmount kısmına
            {
                count++;
                if(count<=gasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString()+ " $";
                    if(totalPrice==(gasolinePrice*gasAmount))
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString()+ " $";
                }
                    
                progressBar1.Value += 1;
                if (progressBar1.Value==99)
                {
                    timer1.Stop();
                }
            }

            if (rdbDiesel.Checked) // dizel seçildiyse ve miktar da girildiyse gasAmount kısmına
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " $";
                    if (totalPrice == (dieselPrice * dieselAmount))
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " $";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }

            if (rdbLpg.Checked) // dizel seçildiyse ve miktar da girildiyse gasAmount kısmına
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpg;
                    txtTotalPrice.Text = totalPrice.ToString() + " $";
                    if (totalPrice == (lpg * lpgAmount))
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " $";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            txtDiesel.Text = dieselPrice.ToString() + " $";
            txtGasoline.Text = gasolinePrice.ToString() + " $";
            txtLpg.Text = lpg.ToString() + " $";
        }
    }
}
