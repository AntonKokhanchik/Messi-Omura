using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_Omura
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BigInt p = new BigInt("2 147 483 647");
			BigInt ea = new BigInt("12 990 277");
			BigInt eb = new BigInt("8 798 723");
			textBox3.Text = Inverse(new BigInt(textBox1.Text), new BigInt(textBox2.Text)).ToString();
		}

		/// <summary>
		/// находит опратное число числу number по модулю module
		/// </summary>
		BigInt Inverse(BigInt number, BigInt module)
		{
			BigInt a = new BigInt(number);
			BigInt b = module, x = new BigInt("0"), d = new BigInt("1");
			while (a != new BigInt("0"))
			{
				BigInt q = b / a;
				BigInt y = a;
				a = b % a;
				b = y;
				y = d;
				d = x - q * d;
				x = y;
			}
			if (b != new BigInt("1"))
				throw new ArgumentException();
			x = x % module;
			if (x.IsNegativeive())
			{
				x = (x + module) % module;
			}
			return x;
		}
	}
}
