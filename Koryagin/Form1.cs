using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koryagin
{
    public partial class Form1 : Form
    {
        public string[] Numbers = new string[1000];
        public string[] RomanNumber = new string[13];
        public string[] ArabicNumber = new string[13];
        public int flag = 0;

        public void Extra_Space()
        {
            string str = textBox1.Text.ToString();
            for (int i = 0; i < (str.Length - 1); i++)
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    textBox2.Paste("При вводе строки не допускается более одного пробела подряд");
                    flag = 1;
                    break;
                }
        }

        public bool Extra_Unit(string str)
        {
            string[] splt = str.Split(' ');
            if (splt.Length > 1)
                for (int i = 0; i < (splt.Length); i++)
                    for (int j = 0; j < 18; j++)
                        if (splt[i] == Numbers[j])
                            for (int k = 0; k < 18; k++)
                                for (int m = (i + 1); m < splt.Length; m++)
                                    if (splt[m] == Numbers[k])
                                        return true;
            return false;
        }

        public bool Extra_Dozen(string str)
        {
            string[] splt = str.Split(' ');
            if (splt.Length > 1)
                for (int i = 0; i < (splt.Length); i++)
                    for (int j = 0; j < 8; j++)
                        if (splt[i] == Numbers[j * 10 + 19])
                            for (int k = 0; k < 8; k++)
                                for (int m = (i + 1); m < splt.Length; m++)
                                    if (splt[m] == Numbers[k * 10 + 19])
                                        return true;
            return false;
        }

        public bool Extra_Hundreds(string str)
        {
            string[] splt = str.Split(' ');
            if (splt.Length > 1)
                for (int i = 0; i < (splt.Length); i++)
                    for (int j = 0; j < 9; j++)
                        if (splt[i] == Numbers[j * 100 + 99])
                            for (int k = 0; k < 9; k++)
                                for (int m = (i + 1); m < splt.Length; m++)
                                    if (splt[m] == Numbers[k * 100 + 99])
                                        return true;
            return false;
        }

        public string Until_Error(string str)
        {
            int flag = 0;
            string[] splt = str.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                flag = 0;
                for (int j = 0; j < 1000; j++)
                {
                    if (splt[i] == Numbers[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) return splt[i];
            }
            return "OK";
        }

        public string Delete_Extra_Space(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] == ' ') && (str[i + 1] == ' '))
                    str = str.Remove(i + 1, 1);
            }
            return str;
        }

        public Form1()
        {
            InitializeComponent();
            Numbers[0] = "один";
            Numbers[1] = "два";
            Numbers[2] = "три";
            Numbers[3] = "четыре";
            Numbers[4] = "пять";
            Numbers[5] = "шесть";
            Numbers[6] = "семь";
            Numbers[7] = "восемь";
            Numbers[8] = "девять";
            Numbers[9] = "десять";
            Numbers[10] = "одиннадцать";
            Numbers[11] = "двенадцать";
            Numbers[12] = "тринадцать";
            Numbers[13] = "четырнадцать";
            Numbers[14] = "пятнадцать";
            Numbers[15] = "шестнадцать";
            Numbers[16] = "семнадцать";
            Numbers[17] = "восемнадцать";
            Numbers[18] = "девятнадцать";
            Numbers[19] = "двадцать";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 20] = Numbers[19] + " " + Numbers[i];
            }
            Numbers[29] = "тридцать";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 30] = Numbers[29] + " " + Numbers[i];
            }
            Numbers[39] = "сорок";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 40] = Numbers[39] + " " + Numbers[i];
            }
            Numbers[49] = "пятьдесят";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 50] = Numbers[49] + " " + Numbers[i];
            }
            Numbers[59] = "шестьдесят";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 60] = Numbers[59] + " " + Numbers[i];
            }
            Numbers[69] = "семьдесят";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 70] = Numbers[69] + " " + Numbers[i];
            }
            Numbers[79] = "восемьдесят";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 80] = Numbers[79] + " " + Numbers[i];
            }
            Numbers[89] = "девяносто";
            for (int i = 0; i < 10; i++)
            {
                Numbers[i + 90] = Numbers[89] + " " + Numbers[i];
            }
            Numbers[99] = "сто";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 100] = Numbers[99] + " " + Numbers[i];
            }
            Numbers[199] = "двести";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 200] = Numbers[199] + " " + Numbers[i];
            }
            Numbers[299] = "триста";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 300] = Numbers[299] + " " + Numbers[i];
            }
            Numbers[399] = "четыреста";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 400] = Numbers[399] + " " + Numbers[i];
            }
            Numbers[499] = "пятьсот";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 500] = Numbers[499] + " " + Numbers[i];
            }
            Numbers[599] = "шестьсот";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 600] = Numbers[599] + " " + Numbers[i];
            }
            Numbers[699] = "семьсот";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 700] = Numbers[699] + " " + Numbers[i];
            }
            Numbers[799] = "восемьсот";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 800] = Numbers[799] + " " + Numbers[i];
            }
            Numbers[899] = "девятьсот";
            for (int i = 0; i < 100; i++)
            {
                Numbers[i + 900] = Numbers[899] + " " + Numbers[i];
            }
            RomanNumber[0] = "I";
            RomanNumber[1] = "IV";
            RomanNumber[2] = "V";
            RomanNumber[3] = "IX";
            RomanNumber[4] = "X";
            RomanNumber[5] = "XL";
            RomanNumber[6] = "L";
            RomanNumber[7] = "XC";
            RomanNumber[8] = "C";
            RomanNumber[9] = "CD";
            RomanNumber[10] = "D";
            RomanNumber[11] = "CM";
            RomanNumber[12] = "M";

            ArabicNumber[0] = "1";
            ArabicNumber[1] = "4";
            ArabicNumber[2] = "5";
            ArabicNumber[3] = "9";
            ArabicNumber[4] = "10";
            ArabicNumber[5] = "40";
            ArabicNumber[6] = "50";
            ArabicNumber[7] = "90";
            ArabicNumber[8] = "100";
            ArabicNumber[9] = "400";
            ArabicNumber[10] = "500";
            ArabicNumber[11] = "900";
            ArabicNumber[12] = "1000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            flag = 0;

            //textBox1.Text = Delete_Extra_Space(textBox1.Text);
            if (textBox1.Text.ToString() == "")
            {
                textBox2.Paste("Поле ввода текста пустое");
            }
            else
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (textBox1.Text.ToString() == Numbers[i])
                    {
                        int num = i + 1;
                        textBox3.Paste(num.ToString());
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    int number = int.Parse(textBox3.Text);
                    string str = "";
                    for (int i = 13 - 1; i >= 0; i--)
                    {
                        int temp = number / int.Parse(ArabicNumber[i]);
                        for (int j = 0; j < temp; j++)
                        {
                            str += RomanNumber[i];
                        }
                        number %= int.Parse(ArabicNumber[i]);
                    }
                    textBox4.Paste(str);
                }
                this.Extra_Space();
                
                if (flag == 0)
                {
                    if (textBox2.Text.ToString() == "")
                    {
                        if (this.Extra_Unit(textBox1.Text.ToString()))
                            textBox2.Text = "Не может быть двух или больше слов единичного формата";
                        if (this.Extra_Dozen(textBox1.Text.ToString()))
                            textBox2.Text = "Не может быть двух или больше слов десятичного формата";
                        if (this.Extra_Hundreds(textBox1.Text.ToString()))
                            textBox2.Text = "Не может быть двух или больше слов формата сотен";
                    }
                    if (textBox2.Text == "")
                    {
                        string OurNumber = textBox1.Text.ToString();
                        string[] Split = OurNumber.Split(' ');
                        switch (Split.Length)
                        {
                            case 1:
                                textBox2.Paste("Разряд единиц составлен неправильно");
                                break;
                            case 2:
                                for (int i = 0; i < 9; i++)
                                {
                                    if (textBox2.Text.ToString() != "")
                                    {
                                        break;
                                    }
                                    if (Split[0] == Numbers[(i * 10) + 19] || Split[0] == Numbers[(i * 100) + 99])
                                    {
                                        textBox2.Paste("Разряд единиц составлен неправильно");
                                        break;
                                    }
                                }
                                for (int i = 0; i < 9; i++)
                                {
                                    if (textBox2.Text.ToString() != "")
                                    {
                                        break;
                                    }
                                    if (Split[1] == Numbers[i])
                                    {
                                        textBox2.Paste("Разряд десятков составлен неправильно");
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                for (int i = 0; i < 9; i++)
                                {
                                    if (Split[0] == Numbers[(i * 100) + 99])
                                    {
                                        for (int j = 0; j < 8; j++)
                                        {
                                            if (textBox2.Text.ToString() != "")
                                            {
                                                break;
                                            }
                                            if (Split[1] == Numbers[(j * 10) + 19])
                                            {
                                                textBox2.Paste("Разряд единиц составлен неправильно");
                                                break;
                                            }
                                        }
                                        for (int j = 0; j < 9; j++)
                                        {
                                            if (textBox2.Text.ToString() != "")
                                            {
                                                break;
                                            }
                                            if (Split[2] == Numbers[j])
                                            {
                                                textBox2.Paste("Разряд десятков составлен неправильно");
                                                break;
                                            }

                                        }
                                    }
                                }
                                for (int i = 0; i < 8; i++)
                                {
                                    if (textBox2.Text.ToString() != "")
                                    {
                                        break;
                                    }
                                    if (Split[1] == Numbers[(i * 10) + 19])
                                    {
                                        textBox2.Paste("Разряд сотен составлен неправильно");
                                        break;
                                    }
                                }
                                for (int i = 0; i < 9; i++)
                                {
                                    if (textBox2.Text.ToString() != "")
                                    {
                                        break;
                                    }
                                    if (Split[2] == Numbers[i])
                                    {
                                        textBox2.Paste("Разряд сотен составлен неправильно");
                                        break;
                                    }
                                }
                                break;
                        }
                    }
                    if (textBox2.Text.ToString() == "")
                    {
                        if (this.Until_Error(textBox1.Text.ToString()) != "OK")
                        {
                            string error = "Допущена ошибка в слове: ";
                            error += this.Until_Error(textBox1.Text.ToString());
                            textBox2.Text = error;
                        }
                    }
                    if (textBox2.Text.ToString() == "")
                    {
                        textBox2.Paste("Число составлено неверно, либо его не существует");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string space = textBox1.Text.ToString();
            for (int i = 0; i < (space.Length - 1); i++)
            {
                if ((space.Length > 1) && (space[i] == ' ') && (space[i + 1] == ' '))
                {
                    //DialogResult mes = MessageBox.Show("Ввод более одного пробела подряд не допустим для работы программы");
                    space = space.Remove(i, 1);
                    textBox1.Text = space;
                    textBox1.SelectionStart = i + 1;
                }
                if (space[0] == ' ')
                {
                    space = space.Remove(0, 1);
                    textBox1.Text = space;
                }
            }
        }
    }
}
