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
                string inp = this.Input.Text;
                string polibish = "ABCDEFGHIJK" +
                                  "LMNOPQRSTUV" +
                                  "WXYZabcdefg" +
                                  "hijklmnopqr" +
                                  "stuvwxyzАБВ" +
                                  "ГДЕЁЖЗИЙКЛМ" +
                                  "НОПРСТУФХЦЧ" +
                                  "ШЩЪЫЬЭЮЯабв" +
                                  "гдеёжзийклм" +
                                  "нопрстуфхцч" +
                                  "шщъыьэюя ";
                int pos_x = 0, pos_y = 0;
                int j = 0;
                string outp = "";
                string chast = "";
                for (int i = 0; i < inp.Length; i++)
                {
                    j = polibish.IndexOf(inp[i]);
                    if (j == -1)
                    {
                        outp += inp[i] + " ";
                    }
                    else
                    {
                        pos_x = j % 11;
                        pos_y = j / 11;
                        if (pos_x == 10)
                        {
                            chast += 'a';
                        }
                        else
                        {
                            chast += pos_x.ToString();
                        }
                        if (pos_y == 10)
                        {
                            chast += 'a';
                        }
                        else
                        {
                            chast += pos_y.ToString();
                        }
                        outp += chast + " ";
                        chast = "";
                    }
                }
                this.Output.Text = outp;
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
                string inp = this.Input.Text;
                string polibish = "ABCDEFGHIJK" +
                                  "LMNOPQRSTUV" +
                                  "WXYZabcdefg" +
                                  "hijklmnopqr" +
                                  "stuvwxyzАБВ" +
                                  "ГДЕЁЖЗИЙКЛМ" +
                                  "НОПРСТУФХЦЧ" +
                                  "ШЩЪЫЬЭЮЯабв" +
                                  "гдеёжзийклм" +
                                  "нопрстуфхцч" +
                                  "шщъыьэюя ";
                int j = 0;
                int pos = 0;
                string outp = "";
                string[] mas = inp.Split(' ');
                int pos_x = 0, pos_y = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i].Length != 2)
                    {
                        outp += mas[i];
                    }
                    else
                    {
                        if (mas[i][0] != 'a')
                        {
                            pos_x = int.Parse(mas[i][0].ToString());
                        }
                        else
                        {
                            pos_x = 10;
                        }
                        if (mas[i][1] != 'a')
                        {
                            pos_y = int.Parse(mas[i][1].ToString());
                        }
                        else
                        {
                            pos_y = 10;
                        }
                        pos = pos_y * 11 + pos_x;
                        outp += polibish[pos];
                    }
                }
                this.Output.Text = outp;
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
