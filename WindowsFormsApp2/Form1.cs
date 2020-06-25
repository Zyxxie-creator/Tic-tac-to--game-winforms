using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       
        public string[] pole = new string[9];
        public string now = "X";
        public int Xwin = 0;
        public int Owin = 0;
        public Form1()
        {

            this.MaximumSize = new Size(513, 412);
            this.MinimumSize = new Size(513, 412);

            InitializeComponent();
            button10.Text = "Рестарт";
         
            clearpole();

        }
        
        private void clearpole()
        {
            this.pole = new string[9];
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

             
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            set(0);
            model();
        }
        private void model()
        {
            string winner = who_win();

            if (winner == "Ничья")
            {
                MessageBox.Show("Ничья!");
                
            }
            if (winner == "X")
            {
                MessageBox.Show("Победили " + "O" + "-ки");
            }
            if (winner == "O")
            {
                MessageBox.Show("Победили " +"X" + "-ки");
            }
        }
        private string who_win()
        {
            // Горизонталь 
            if (this.pole[0] == this.pole[1] & this.pole[1] == this.pole[2])
                return this.pole[0];
            if (this.pole[3] == this.pole[4] & this.pole[4] == this.pole[5])
                return this.pole[3];
            if (this.pole[6] == this.pole[7] & this.pole[7] == this.pole[8])
                return this.pole[6];
            //Вертикаль 
            if (this.pole[0] == this.pole[4] & this.pole[4] == this.pole[6])
                return this.pole[0];
            if (this.pole[1] == this.pole[5] & this.pole[5] == this.pole[7])
                return this.pole[1];
            if (this.pole[2] == this.pole[3] & this.pole[3] == this.pole[8])
                return this.pole[2];
            // Горизонтали 
            if (this.pole[0] == this.pole[5] & this.pole[5] == this.pole[8])
                return this.pole[0];
            if (this.pole[2] == this.pole[5] & this.pole[5] == this.pole[6])
                return this.pole[2];
            int a = 0;
            foreach (string value in this.pole)
            {
                if (value != null) a++;
            }

            if ((a - 9) == 0) return "Ничья";
            return "false";
        }
        private void set(int cell)
        {
            if (this.pole[cell] != null)
            {
                MessageBox.Show("Место занято!");
                return;
            }
            this.pole[cell] = this.now;
            if (this.now == "X")
            {
                this.now = "O";
                switch (cell)
                {
                    case 0:
                        button1.Text = "O";
                        break;
                    case 1:
                        button2.Text = "O";
                        break;
                    case 2:
                        button3.Text = "O";
                        break;
                    case 3:
                        button4.Text = "O";
                        break;
                    case 4:
                        button5.Text = "O";
                        break;
                    case 5:
                        button6.Text = "O";
                        break;
                    case 6:
                        button7.Text = "O";
                        break;
                    case 7:
                        button8.Text = "O";
                        break;
                    case 8:
                        button9.Text = "O";
                        break;
                }
                this.Text = "X";
            }
            else if (this.now == "O")
            {
                this.now = "X";
                switch (cell)
                {
                    case 0:
                        button1.Text = "X";
                        break;
                    case 1:
                        button2.Text = "X";
                        break;
                    case 2:
                        button3.Text = "X";
                        break;
                    case 3:
                        button4.Text = "X";
                        break;
                    case 4:
                        button5.Text = "X";
                        break;
                    case 5:
                        button6.Text = "X";
                        break;
                    case 6:
                        button7.Text = "X";
                        break;
                    case 7:
                        button8.Text = "X";
                        break;
                    case 8:
                        button9.Text = "X";
                        break;
                }
                this.Text = "O";
            }
            return;
        }

    private void Button2_Click(object sender, EventArgs e)
        {
            set(1);
            model();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            set(2);
            model();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            set(4);
            model();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            set(5);
            model();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            set(3);
            model();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            set(6);
            model();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            set(7);
            model();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            set(8);
            model();
        }
    }
}
