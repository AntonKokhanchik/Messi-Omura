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

		private void Form1_Load(object sender, EventArgs e)
		{
			BigInt p = new BigInt("2 147 483 647");
			BigInt ea = new BigInt("12 990 277");
			BigInt eb = new BigInt("8 798 723");

			textBoxModule.Text = p.ToString();
			textBoxEncodeA.Text = ea.ToString();
			textBoxEncodeB.Text = eb.ToString();
		}

		private void buttonKeys_Click(object sender, EventArgs e)
		{
			textBoxDecodeA.Text = Inverse(new BigInt(textBoxEncodeA.Text), new BigInt(textBoxModule.Text)).ToString();
			textBoxDecodeB.Text = Inverse(new BigInt(textBoxEncodeB.Text), new BigInt(textBoxModule.Text)).ToString();
		}

		private void buttonSendA_Click(object sender, EventArgs e)
		{
			textBoxB.Text = textBoxA.Text;
			textBoxA.Clear();
		}

		private void buttonSendB_Click(object sender, EventArgs e)
		{
			textBoxA.Text = textBoxB.Text;
			textBoxB.Clear();
		}

		private void buttonEncodeA_Click(object sender, EventArgs e)
		{
			BigInt p = new BigInt(textBoxModule.Text);
			BigInt ea = new BigInt(textBoxEncodeA.Text);
			BigInt message = new BigInt(textBoxA.Text);
			textBoxA.Text = ((message * ea) % p).ToString();
		}

		private void buttonDecodeB_Click(object sender, EventArgs e)
		{
			BigInt p = new BigInt(textBoxModule.Text);
			BigInt eb = new BigInt(textBoxEncodeB.Text);
			BigInt message = new BigInt(textBoxB.Text);
			textBoxB.Text = ((message * eb) % p).ToString();
		}

		private void buttonDecodeA_Click(object sender, EventArgs e)
		{
			BigInt p = new BigInt(textBoxModule.Text);
			BigInt da = new BigInt(textBoxDecodeA.Text);
			BigInt message = new BigInt(textBoxA.Text);
			textBoxA.Text = ((message * da) % p).ToString();
		}

		private void buttonEncodeB_Click(object sender, EventArgs e)
		{
			BigInt p = new BigInt(textBoxModule.Text);
			BigInt db = new BigInt(textBoxDecodeB.Text);
			BigInt message = new BigInt(textBoxB.Text);
			textBoxB.Text = ((message * db) % p).ToString();
		}
	}
}
