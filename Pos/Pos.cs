using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;


namespace Pos
{
    public partial class Pos : Form
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Pos));
        int ActiveBtn = 1;

        Guna.UI.Lib.ScrollBar.PanelScrollHelper vsCroll = null;

        public Pos()
        {
            InitializeComponent();

           
            //int col = 6;
            //int leftBox = 6;
            //Actived Btn
            btnMenu1.BaseColor = Color.FromArgb(62, 112, 168);
            ActiveBtn = 1;

            Components.CpOrder test = new Components.CpOrder(ref vsCroll,
                                                             scrollStore,
                                                             ref panelStore,
                                                             setTotalMoney);
            gunaPanel8.Controls.Add(test);
            test.Dock = DockStyle.Fill;

            vsCroll.UpdateScrollBar();


            //int widthBox = Menu1.Width / col;
            //leftBox = (Menu1.Width - widthBox * col) / (col + 1) + leftBox;
            //for (int i = 0; i < col; i++)
            //{
            //    Card newCard = new Card(resources, widthBox - leftBox, leftBox * 5, "Con gà con", "19000");
            //    Menu1.Controls.Add(newCard);
            //}
            //for (int i = 0; i < col; i++)
            //{
            //    Card newCard = new Card(resources, widthBox - leftBox, leftBox * 5, "Con gà con", "19000");
            //    Menu2.Controls.Add(newCard);
            //}
            //for (int i = 0; i < col; i++)
            //{
            //    Card newCard = new Card(resources, widthBox - leftBox, leftBox * 5, "Con gà con", "19000");
            //    Menu3.Controls.Add(newCard);
            //}
        }

        private void resetBtn(int btn)
        {
            switch (btn)
            {
                case 1:
                    btnMenu1.BaseColor = Color.FromArgb(72, 130, 195);
                    break;
                case 2:
                    btnMenu2.BaseColor = Color.FromArgb(72, 130, 195);
                    break;
                case 3:
                    btnMenu3.BaseColor = Color.FromArgb(72, 130, 195);
                    break;
                case 4:
                    btnMenu4.BaseColor = Color.FromArgb(72, 130, 195);
                    break;
                default:
                    break;
            }
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            resetBtn(ActiveBtn);
            btnMenu1.BaseColor = Color.FromArgb(62, 112, 168);
            ActiveBtn = 1;
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            resetBtn(ActiveBtn);
            btnMenu2.BaseColor = Color.FromArgb(62, 112, 168);
            ActiveBtn = 2;
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            resetBtn(ActiveBtn);
            btnMenu3.BaseColor = Color.FromArgb(62, 112, 168);
            ActiveBtn = 3;
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            resetBtn(ActiveBtn);
            btnMenu4.BaseColor = Color.FromArgb(62, 112, 168);
            ActiveBtn = 4;
        }

        private void pannelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void setTotalMoney(double price)
        {
            totalMoney.Text = string.Format("{0:0,0}đ", price);
        }
    }
}
