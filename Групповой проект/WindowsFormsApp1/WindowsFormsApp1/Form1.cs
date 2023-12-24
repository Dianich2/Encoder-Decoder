using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Shifr : Form
    {
        public Shifr()
        {
            InitializeComponent();
        }
        private void Shifrator_Click(object sender, EventArgs e)
        {
            if (Shifr1.Checked)
            {
                string inp = this.Input.Text;
                string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                string shifr_letter = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcbaЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБАяюэьыъщшчцхфутсрпонмлкйизжёедгвба";
                long l = inp.Length;
                string outp = "";
                int pos;
                for (int i = 0; i < l; i++)
                {
                    pos = letter.IndexOf(inp[i]);
                    if (pos != -1)
                    {
                        outp += shifr_letter[pos];
                    }
                    else
                    {
                        outp += inp[i];
                    }

                }
                this.Output.Text = outp;
            }
            if (Shifr2.Checked)
            {
                
            }
            if (Shifr3.Checked)
            {
                
            }
            if (Shifr4.Checked)
            {
                
            }
            if (Shifr5.Checked)
            {
               
            }
        }

        private void Deshifrator_Click(object sender, EventArgs e)
        {
            if (Shifr1.Checked)
            {
                string inp = this.Input.Text;
                string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                string shifr_letter = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcbaЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБАяюэьыъщшчцхфутсрпонмлкйизжёедгвба";
                long l = inp.Length;
                string outp = "";
                int pos;
                for (int i = 0; i < l; i++)
                {
                    pos = letter.IndexOf(inp[i]);
                    if (pos != -1)
                    {
                        outp += shifr_letter[pos];
                    }
                    else
                    {
                        outp += inp[i];
                    }

                }
                this.Output.Text = outp;
            }
            if (Shifr2.Checked)
            {
                
            }
            if (Shifr3.Checked)
            {
                
            }
            if (Shifr4.Checked)
            {
                
            }
            if (Shifr5.Checked)
            {
                
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (this.Input.Text != "")
            {
                Shifrator.Enabled = true;
                Deshifrator.Enabled = true;
                this.Clean_input.Enabled = true;
            }
            else if(this.Input.Text == "")
            {
                Shifrator.Enabled = false;
                Deshifrator.Enabled = false;
                this.Clean_input.Enabled = false;
            }
        }

        private void Clean_input_Click(object sender, EventArgs e)
        {
            this.Input.Text = "";
        }

        private void Clean_output_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            if (this.Output.Text != "")
            {
                this.Clean_output.Enabled = true;
            }
            else if (this.Output.Text == "")
            {
                this.Clean_output.Enabled = false;
            }
        }
    }
}
