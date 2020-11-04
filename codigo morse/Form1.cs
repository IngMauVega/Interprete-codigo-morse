using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codigo_morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orig = txtoriginal.Text;
            string morse="";
            lbl1.Visible = true;
            txtmorse.Visible = true;
            if (orig.Contains("A") == true)
            {               
                morse = orig = orig.Replace("A", ".-");
            }
            if (orig.Contains("B") == true)
            {
                 morse = orig = orig.Replace("B","-...");
            }
            if (orig.Contains(" ") == true)
            {
                 morse = orig = orig.Replace(" ","   ");
            }
            if (orig.Contains("C") == true)
            {
                 morse = orig = orig.Replace("C","-.-.");
            }
            if (orig.Contains("CH") == true)
            {
                 morse = orig = orig.Replace("CH","----");
            }
            if (orig.Contains("D") == true)
            {
                 morse = orig = orig.Replace("D","-..");
            }
            if (orig.Contains("E") == true)
            {
                 morse = orig = orig.Replace("E",".");
            }
            if (orig.Contains("F") == true)
            {
                 morse = orig = orig.Replace("F","..-.");
            }
            if (orig.Contains("G") == true)
            {
                 morse = orig = orig.Replace("G","--.");
            }
            if (orig.Contains("H") == true)
            {
                 morse = orig = orig.Replace("H","....");
            }
            if (orig.Contains("I") == true)
            {
                 morse = orig = orig.Replace("I","..");
            }
            if (orig.Contains("J") == true)
            {
                 morse = orig = orig.Replace("J",".---");
            }
            if (orig.Contains("K") == true)
            {
                 morse = orig = orig.Replace("K","-.-");
            }
            if (orig.Contains("L") == true)
            {
                 morse = orig = orig.Replace("L",".-..");
            }
            if (orig.Contains("M") == true)
            {
                 morse = orig = orig.Replace("M","--");
            }
            if (orig.Contains("N") == true)
            {
                 morse = orig = orig.Replace("N","-.");
            }
            if (orig.Contains("Ñ") == true)
            {
                 morse = orig = orig.Replace("Ñ", "--.--");
            }
            if (orig.Contains("O") == true)
            {
                 morse = orig = orig.Replace("O","---");
            }
            if (orig.Contains("P") == true)
            {
                 morse = orig = orig.Replace("P",".--.");
            }
            if (orig.Contains("Q") == true)
            {
                 morse = orig = orig.Replace("Q","--.-");
            }
            if (orig.Contains("R") == true)
            {
                 morse = orig = orig.Replace("R",".-.");
            }
            if (orig.Contains("S") == true)
            {
                 morse = orig = orig.Replace("S","...");
            }
            if (orig.Contains("T") == true)
            {
                 morse = orig = orig.Replace("T","-");
            }
            if (orig.Contains("U") == true)
            {
                 morse = orig = orig.Replace("U","..-");
            }
            if (orig.Contains("V") == true)
            {
                 morse = orig = orig.Replace("V","...-");
            }
            if (orig.Contains("W") == true)
            {
                 morse = orig = orig.Replace("W",".--");
            }
            if (orig.Contains("X") == true)
            {
                 morse = orig = orig.Replace("X","-..-");
            }
            if (orig.Contains("Y") == true)
            {
                 morse = orig = orig.Replace("Y","-.--");
            }
            if (orig.Contains("Z") == true)
            {
                 morse = orig = orig.Replace("Z","--..");
            }
            if (orig.Contains("1") == true)
            {
                 morse = orig = orig.Replace("1",".----");
            }
            if (orig.Contains("2") == true)
            {
                 morse = orig = orig.Replace("2","..---");
            }
            if (orig.Contains("3") == true)
            {
                 morse = orig = orig.Replace("3","...--");
            }
            if (orig.Contains("4") == true)
            {
                 morse = orig = orig.Replace("4","....-");
            }
            if (orig.Contains("5") == true)
            {
                 morse = orig = orig.Replace("5",".....");
            }
            if (orig.Contains("6") == true)
            {
                 morse = orig = orig.Replace("6","-....");
            }
            if (orig.Contains("7") == true)
            {
                 morse = orig = orig.Replace("7","--...");
            }
            if (orig.Contains("8") == true)
            {
                 morse = orig = orig.Replace("8","---..");
            }
            if (orig.Contains("9") == true)
            {
                 morse = orig = orig.Replace("9","----.");
            }
            if (orig.Contains("0") == true)
            {
                 morse = orig = orig.Replace("0","-----");
            }
            txtmorse.Text = morse;
        }
    }
}
