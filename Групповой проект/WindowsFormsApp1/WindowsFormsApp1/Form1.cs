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
                string[] morseCodes = {"1.-","1-...","1-.-.","1-..","1.","1..-.","1--.","1....","1..","1.---","1-.-","1.-..",
"1--","1-.","1---","1.--.", "1--.-","1.-.","1...","1-","1..-","1...-","1.--","1-..-","1-.--","1--..",
"2.-","2-...","2-.-.","2-..","2.","2..-.","2--.","2....","2..","2.---","2-.-","2.-..","2--","2-.","2---","2.--.", "2--.-",
"2.-.","2...","2-","2..-","2...-","2.--","2-..-","2-.--","2--..",
"3.-","3-...","3.--","3--.","3-..","3.","3...-","3--..","3..","3.---","3-.-","3.-..","3--","3-.","3---","3.--.","3.-.","3...",
"3-","3..-","3..-.","3....","3-.-.","3---.","3----","3--.-","3.--.-.","3-.--","3-..-","3..-..","3..--","3.-.-",
"4.-","4-...","4.--","4--.","4-..","4.","4...-","4--..","4..","4.---","4-.-","4.-..","4--","4-.","4---","4.--.","4.-.","4...",
"4-","4..-","4..-.","4....","4-.-.","4---.","4----","4--.-","4.--.-.","4-.--","4-..-","4..-..","4..--","4.-.-","0.----","0..---","0...--","0....-",
"0.....", "0-....","0--...","0---..","0----.","0-----","0......","0.-.-.-","0--..--","0..--..","0-.-.-.","0---...","0.-.-.","0-...-",
"0..--.-","0-..-.","0-.--.","0-.--.-","0.-...","0...-..-","0.--.-.","0-....-","0..........","3-.-.-.-.-.","4-.-.-.-.-.","0.-.-.-.","0-.-.-.-","0--.--.--","0..-..-..","0...--..","0....--..","0----..--","0-..-..-.-","0..-...--..","0..-...----","0--.---..--","0--.---....","0--..---...-"};

                char[] symb = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
'T', 'U', 'V', 'W', 'X', 'Y', 'Z','a','b','c','d','e', 'f', 'g','h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
't', 'u', 'v', 'w', 'x', 'y', 'z', 'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х',
'Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю', 'Я', 'а','б','в','г','д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
'х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я','1','2','3','4','5','6','7','8','9','0','.',',','!','?',';',':','+','=','_','/','(',')','&','$','@','-',' ','Ё','ё','>','<','#','№','%','^','*','\\','{','}','[',']','~'};

                string message = this.Input.Text;
                string encryptedMessage = "";
                int l = 0;
                foreach (char c in message)
                {
                    l = Array.IndexOf(symb, c);
                    if (l != -1)
                    {
                        encryptedMessage += morseCodes[l];
                    }
                }
                this.Output.Text = encryptedMessage;

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
                string[] morseCodes = {"1.-","1-...","1-.-.","1-..","1.","1..-.","1--.","1....","1..","1.---","1-.-","1.-..",
"1--","1-.","1---","1.--.", "1--.-","1.-.","1...","1-","1..-","1...-","1.--","1-..-","1-.--","1--..",
"2.-","2-...","2-.-.","2-..","2.","2..-.","2--.","2....","2..","2.---","2-.-","2.-..","2--","2-.","2---","2.--.", "2--.-",
"2.-.","2...","2-","2..-","2...-","2.--","2-..-","2-.--","2--..",
"3.-","3-...","3.--","3--.","3-..","3.","3...-","3--..","3..","3.---","3-.-","3.-..","3--","3-.","3---","3.--.","3.-.","3...",
"3-","3..-","3..-.","3....","3-.-.","3---.","3----","3--.-","3.--.-.","3-.--","3-..-","3..-..","3..--","3.-.-",
"4.-","4-...","4.--","4--.","4-..","4.","4...-","4--..","4..","4.---","4-.-","4.-..","4--","4-.","4---","4.--.","4.-.","4...",
"4-","4..-","4..-.","4....","4-.-.","4---.","4----","4--.-","4.--.-.","4-.--","4-..-","4..-..","4..--","4.-.-","0.----","0..---","0...--","0....-",
"0.....", "0-....","0--...","0---..","0----.","0-----","0......","0.-.-.-","0--..--","0..--..","0-.-.-.","0---...","0.-.-.","0-...-",
"0..--.-","0-..-.","0-.--.","0-.--.-","0.-...","0...-..-","0.--.-.","0-....-","0..........","3-.-.-.-.-.","4-.-.-.-.-.","0.-.-.-.","0-.-.-.-","0--.--.--","0..-..-..","0...--..","0....--..","0----..--","0-..-..-.-","0..-...--..","0..-...----","0--.---..--","0--.---....","0--..---...-"};

                char[] symb = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
'T', 'U', 'V', 'W', 'X', 'Y', 'Z','a','b','c','d','e', 'f', 'g','h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
't', 'u', 'v', 'w', 'x', 'y', 'z', 'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х',
'Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю', 'Я', 'а','б','в','г','д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
'х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я','1','2','3','4','5','6','7','8','9','0','.',',','!','?',';',':','+','=','_','/','(',')','&','$','@','-',' ','Ё','ё','>','<','#','№','%','^','*','\\','{','}','[',']','~'};

                string morsCode = this.Input.Text;
                bool t = true;
                for (int i = 0; i < morsCode.Length; i++)
                {
                    if (morsCode[i] != '1' && morsCode[i] != '2' && morsCode[i] != '3' && morsCode[i] != '4' && morsCode[i] != '0' && morsCode[i] != '-' && morsCode[i] != '.')
                    {
                        t = false;
                        this.Output.Text = "";
                        break;
                    }
                }
                if (t)
                {
                    string mo = morsCode;
                    string[] mas = morsCode.Split('1', '2', '3', '4', '0');
                    string[] f = mo.Split('-', '.');
                    string h = string.Join(" ", f);
                    h = h.Replace(" ", "");
                    string dec = "";
                    string decodedText = "";
                    int j = 0;
                    int k = 0;
                    int l = 0;
                    for (int i = 0; i < h.Length; i++)
                    {
                        if (mas[k] == "" || mas[k] == " ")
                        {
                            k++;
                        }
                        dec = h[i] + mas[k];
                        l = Array.IndexOf(morseCodes, dec);
                        if (l != -1)
                        {
                            decodedText += symb[l];
                        }
                        k++;
                        dec = "";
                    }
                    this.Output.Text = decodedText;
                }
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
