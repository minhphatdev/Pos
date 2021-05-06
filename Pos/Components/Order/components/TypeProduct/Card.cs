using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos.Components.Order
{
    public partial class Card : UserControl
    {

        private string index;
        private bool active;
        public Card(bool active,string number, string content, int inWidth,int position, EventHandler evo)
        {
            InitializeComponent();

            Number.Text = number;
            setIndex(number);
            Content.Text = content;
            Width = inWidth;
            Layout.Width = inWidth;

            Location = new Point(position, 10);

            if (active)
            {
                selectived();
                this.active = active;
            }    

            Number.Click += evo;
            Content.Click += evo;

          
        }

        private void Number_MouseEnter(object sender, EventArgs e)
        {
            setActiveEnter(active);
        }

        private void Content_MouseEnter(object sender, EventArgs e)
        {
            setActiveEnter(active);
        }

        private void Number_MouseLeave(object sender, EventArgs e)
        {
            setActiveLeave(active);
        }

        private void Content_MouseLeave(object sender, EventArgs e)
        {
            setActiveLeave(active);
        }

        public void selectived()
        {
            active=true;
            setActiveLeave(active);
        }

        public void unSelectived()
        {
            active = false;
            setActiveLeave(active);
        }

        public void setActiveLeave(bool check)
        {
            if (check)
            {
                DsCard.BaseColor = Color.FromArgb(72, 130, 195);
                Number.ForeColor = Color.FromArgb(255, 255, 255);
                Content.ForeColor = Color.FromArgb(255, 255, 255);
                return;
            }
            DsCard.BaseColor = Color.FromArgb(255, 255, 255);
            Number.ForeColor = Color.FromArgb(72, 130, 195);
            Content.ForeColor = Color.FromArgb(72, 130, 195);
        }

        public void setActiveEnter(bool check)
        {
            if (check)
            {
                DsCard.BaseColor = Color.FromArgb(72, 130, 195);
                Number.ForeColor = Color.FromArgb(255, 255, 255);
                Content.ForeColor = Color.FromArgb(255, 255, 255);
                return;
            }
            DsCard.BaseColor = Color.FromArgb(231, 242, 255);
            Number.ForeColor = Color.FromArgb(72, 130, 195);
            Content.ForeColor = Color.FromArgb(72, 130, 195);
        }

        public void setIndex(string index)
        {
            this.index = index;
        }

        public int getIndex()
        {
            return int.Parse(index);
        }
    }
}
