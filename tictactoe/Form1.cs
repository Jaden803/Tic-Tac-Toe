//Created by Jaden Guidangen
//Date: July 24th 2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool player_x;
        public Form1()
        {
            InitializeComponent();
            r1_c1_O_box.Hide();
            r1_c2_O_Box.Hide();
            r1_c3_O_box.Hide();
            r2_c1_O_Box.Hide();
            r2_c2_O_Box.Hide();
            r2_c3_O_Box.Hide();
            r3_c1_O_Box.Hide();
            r3_c2_O_Box.Hide();
            r3_c3_O_Box.Hide();

            r1_c1_x_box.Hide();
            r1_c2_x_box.Hide();
            r1_c3_x_box.Hide();
            r2_c1_x_box.Hide();
            r2_c2_x_box.Hide();
            r2_c3_x_box.Hide();
            r3_c1_x_box.Hide();
            r3_c2_x_box.Hide();
            r3_c3_x_box.Hide();

            r1_c1_button.Hide();
            r1_c2_button.Hide();
            r1_c3_button.Hide();
            r2_c1_button.Hide();
            r2_c2_button.Hide();
            r2_c3_button.Hide();
            r3_c1_button.Hide();
            r3_c2_button.Hide();
            r3_c3_button.Hide();



        }
        //help prevent creating multiple messageboxes
        bool win = false;
        void check_winner()
        {
            Button[] arry_button = { r1_c1_button, r1_c2_button, r1_c3_button, r2_c1_button, r2_c2_button, r2_c3_button, r3_c1_button, r3_c2_button, r3_c3_button };
            PictureBox[] img_x = { r1_c1_x_box, r1_c2_x_box, r1_c3_x_box, r2_c1_x_box, r2_c2_x_box, r2_c3_x_box, r3_c1_x_box, r3_c2_x_box, r3_c3_x_box };
            PictureBox[] img_o = { r1_c1_O_box, r1_c2_O_Box, r1_c3_O_box, r2_c1_O_Box, r2_c2_O_Box, r2_c3_O_Box, r3_c1_O_Box, r3_c2_O_Box, r3_c3_O_Box };
            if (player_x)
            {
                if (img_x[0].Visible == true && img_x[1].Visible == true && img_x[2].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[3].Visible == true && img_x[4].Visible == true && img_x[5].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[6].Visible == true && img_x[7].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[6].Visible == true && img_x[7].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[0].Visible == true && img_x[3].Visible == true && img_x[6].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[1].Visible == true && img_x[4].Visible == true && img_x[7].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[2].Visible == true && img_x[5].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[0].Visible == true && img_x[4].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (img_x[2].Visible == true && img_x[4].Visible == true && img_x[6].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    this.Close();
                    win = true;
                }
                else if (arry_button[0].Visible == false && arry_button[1].Visible == false && arry_button[2].Visible == false && arry_button[3].Visible == false && arry_button[4].Visible == false && arry_button[5].Visible == false && arry_button[6].Visible == false && arry_button[7].Visible == false && arry_button[8].Visible == false && win == false)
                {
                    MessageBox.Show("Draw");
                    win = true;
                }

            }
            else
            {
                if (img_o[0].Visible == true && img_o[1].Visible == true && img_o[2].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[3].Visible == true && img_o[4].Visible == true && img_o[5].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[6].Visible == true && img_o[7].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[6].Visible == true && img_o[7].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[0].Visible == true && img_o[3].Visible == true && img_o[6].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[1].Visible == true && img_o[4].Visible == true && img_o[7].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[2].Visible == true && img_o[5].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[0].Visible == true && img_o[4].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (img_o[2].Visible == true && img_o[4].Visible == true && img_o[6].Visible == true)
                {
                    MessageBox.Show("You Win!");
                    win = true;
                    this.Close();
                }
                else if (arry_button[0].Visible == false && arry_button[1].Visible == false && arry_button[2].Visible == false && arry_button[3].Visible == false && arry_button[4].Visible == false && arry_button[5].Visible == false && arry_button[6].Visible == false && arry_button[7].Visible == false && arry_button[8].Visible == false && win == false)
                {
                    MessageBox.Show("Draw");
                    win = true;
                }

            }
        }

        void check_comp_win()
        {
            Button[] arry_button = { r1_c1_button, r1_c2_button, r1_c3_button, r2_c1_button, r2_c2_button, r2_c3_button, r3_c1_button, r3_c2_button, r3_c3_button };
            PictureBox[] img_x = { r1_c1_x_box, r1_c2_x_box, r1_c3_x_box, r2_c1_x_box, r2_c2_x_box, r2_c3_x_box, r3_c1_x_box, r3_c2_x_box, r3_c3_x_box };
            PictureBox[] img_o = { r1_c1_O_box, r1_c2_O_Box, r1_c3_O_box, r2_c1_O_Box, r2_c2_O_Box, r2_c3_O_Box, r3_c1_O_Box, r3_c2_O_Box, r3_c3_O_Box };
            if (player_x)
            {
                if (img_o[0].Visible == true && img_o[1].Visible == true && img_o[2].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[3].Visible == true && img_o[4].Visible == true && img_o[5].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[6].Visible == true && img_o[7].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[6].Visible == true && img_o[7].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!!");
                    win = true;
                    this.Close();
                }
                else if (img_o[0].Visible == true && img_o[3].Visible == true && img_o[6].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[1].Visible == true && img_o[4].Visible == true && img_o[7].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[2].Visible == true && img_o[5].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[0].Visible == true && img_o[4].Visible == true && img_o[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_o[2].Visible == true && img_o[4].Visible == true && img_o[6].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (arry_button[0].Visible == false && arry_button[1].Visible == false && arry_button[2].Visible == false && arry_button[3].Visible == false && arry_button[4].Visible == false && arry_button[5].Visible == false && arry_button[6].Visible == false && arry_button[7].Visible == false && arry_button[8].Visible == false && win == false)
                {
                    MessageBox.Show("Draw");
                    win = true;
                }

            }
            else
            {
                if (img_x[0].Visible == true && img_x[1].Visible == true && img_x[2].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[3].Visible == true && img_x[4].Visible == true && img_x[5].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[6].Visible == true && img_x[7].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[6].Visible == true && img_x[7].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[0].Visible == true && img_x[3].Visible == true && img_x[6].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[1].Visible == true && img_x[4].Visible == true && img_x[7].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[2].Visible == true && img_x[5].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[0].Visible == true && img_x[4].Visible == true && img_x[8].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (img_x[2].Visible == true && img_x[4].Visible == true && img_x[6].Visible == true)
                {
                    MessageBox.Show("Comp Wins!");
                    win = true;
                    this.Close();
                }
                else if (arry_button[0].Visible == false && arry_button[1].Visible == false && arry_button[2].Visible == false && arry_button[3].Visible == false && arry_button[4].Visible == false && arry_button[5].Visible == false && arry_button[6].Visible == false && arry_button[7].Visible == false && arry_button[8].Visible == false && win == false)
                {
                    MessageBox.Show("Draw");
                    win = true;
                }

            }
        }
        void comp_turn()
        {
            Button[] arry_button = { r1_c1_button, r1_c2_button, r1_c3_button, r2_c1_button, r2_c2_button, r2_c3_button, r3_c1_button, r3_c2_button, r3_c3_button };
            PictureBox[] img_x = { r1_c1_x_box, r1_c2_x_box, r1_c3_x_box, r2_c1_x_box, r2_c2_x_box, r2_c3_x_box, r3_c1_x_box, r3_c2_x_box, r3_c3_x_box };
            PictureBox[] img_o = { r1_c1_O_box, r1_c2_O_Box, r1_c3_O_box, r2_c1_O_Box, r2_c2_O_Box, r2_c3_O_Box, r3_c1_O_Box, r3_c2_O_Box, r3_c3_O_Box };
            Random ran = new Random();
            bool comp = true;
            //if player chooses x
            if (player_x)
            {
                while (comp)
                {
                    //creating more randomness
                    for (int i = 0; i<9; i++)
                    {
                        int index = ran.Next(0,9);
                        if (arry_button[index].Visible == true)
                        {
                            arry_button[index].Visible = false;
                            img_o[index].Visible = true;
                            comp = false;
                            break;

                        }
                        else
                        {
                            

                        }
                    }
                    break;
                }
                
            }
            //if player chooses o
            else
            {
                while (comp)
                {
                    //creating more randomness
                    for (int i = 0; i < 9; i++)
                    {
                        int index = ran.Next(0, 9);
                        if (arry_button[index].Visible == true)
                        {
                            arry_button[index].Visible = false;
                            img_x[index].Visible = true;
                            comp = false;
                            break;

                        }
                        else
                        {


                        }
                    }
                    break;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void r1_c3_O_box_Click(object sender, EventArgs e)
        {
            r1_c3_O_box.Visible = true;
        }

        private void r1_c1_button_Click(object sender, EventArgs e)
        {
            r1_c1_button.Visible = false;
            if (player_x)
            {
                r1_c1_x_box.Visible = true;
            }
            else
            {
                r1_c1_O_box.Visible = true;
            }
            comp_turn();        
            check_winner();
            check_comp_win();

        }

        private void r1_c2_button_Click(object sender, EventArgs e)
        {
            r1_c2_button.Visible = false;
            if (player_x)
            {
                r1_c2_x_box.Visible = true;
            }
            else
            {
                r1_c2_O_Box.Visible = true;
            }
            comp_turn();
            check_comp_win();
            check_winner();


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void r1_c3_button_Click(object sender, EventArgs e)
        {
            r1_c3_button.Visible = false;
            if (player_x)
            {
                r1_c3_x_box.Visible = true;
            }
            else
            {
                r1_c3_O_box.Visible = true;
            }
            comp_turn();
            check_winner();
            check_comp_win();
        }

        private void r2_c1_button_Click(object sender, EventArgs e)
        {
            r2_c1_button.Visible = false;
            if (player_x)
            {
                r2_c1_x_box.Visible = true;
            }
            else
            {
                r2_c1_O_Box.Visible = true;
            }
            comp_turn(); 
            check_winner();
            check_comp_win();
        }

        private void r2_c2_button_Click(object sender, EventArgs e)
        {
            r2_c2_button.Visible = false;
            if (player_x)
            {
                r2_c2_x_box.Visible = true;
            }
            else
            {
                r2_c2_O_Box.Visible = true;
            }
            comp_turn();
            check_winner();
            check_comp_win();
        }

        private void r2_c2_x_box_Click(object sender, EventArgs e)
        {

        }

        private void r2_c3_button_Click(object sender, EventArgs e)
        {
            r2_c3_button.Visible = false;
            if (player_x)
            {
                r2_c3_x_box.Visible = true;
            }
            else
            {
                r2_c3_O_Box.Visible = true;
            }
            comp_turn();           
            check_winner();
            check_comp_win();
        }

        private void r3_c1_button_Click(object sender, EventArgs e)
        {
            r3_c1_button.Visible = false;
            if (player_x)
            {
                r3_c1_x_box.Visible = true;
            }
            else
            {
                r3_c1_O_Box.Visible = true;
            }
            comp_turn();            
            check_winner();
            check_comp_win();
        }

        private void r3_c2_button_Click(object sender, EventArgs e)
        {
            r3_c2_button.Visible = false;
            if (player_x)
            {
                r3_c2_x_box.Visible = true;
            }
            else
            {
                r3_c2_O_Box.Visible = true;
            } 
            comp_turn();
            check_comp_win();
            check_winner();

        }

        private void r3_c3_button_Click(object sender, EventArgs e)
        {
            r3_c3_button.Visible = false;
            if (player_x)
            {
                r3_c3_x_box.Visible = true;
            }
            else
            {
                r3_c3_O_Box.Visible = true;
            }
            comp_turn();
            check_winner();
            check_comp_win();
        }

        private void play_x_button_Click(object sender, EventArgs e)
        {
            player_x = true;
            play_x_button.Visible = false;
            play_o_button.Visible = false;
            r1_c1_button.Show();
            r1_c2_button.Show();
            r1_c3_button.Show();
            r2_c1_button.Show();
            r2_c2_button.Show();
            r2_c3_button.Show();
            r3_c1_button.Show();
            r3_c2_button.Show();
            r3_c3_button.Show();
        }

        private void play_o_button_Click(object sender, EventArgs e)
        {
            player_x = false;
            play_o_button.Visible = false;
            play_x_button.Visible = false;
            r1_c1_button.Show();
            r1_c2_button.Show();
            r1_c3_button.Show();
            r2_c1_button.Show();
            r2_c2_button.Show();
            r2_c3_button.Show();
            r3_c1_button.Show();
            r3_c2_button.Show();
            r3_c3_button.Show();
        }
    }
}
