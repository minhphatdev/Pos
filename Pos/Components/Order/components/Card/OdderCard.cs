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
    public partial class OdderCard : UserControl
    {

        public OdderCard(Common.Item item, int width, int position, int height, EventHandler e)
        {
            InitializeComponent();
            Width = width;
            Height = 297;
            Location = new Point(position, height);
            name.Text = item.Name;
            price.Text = string.Format("{0:0,0}đ", item.Price);
            gunaPicture.LoadAsync("https://static.suno.vn/public/cf84a1a0-1cd0-4c3b-bc10-c73a09adcbb0/63750776240971637635703.jpg");

            price.Click += e;
            name.Click += e;
            gunaPicture.Click += e;
        }

        private void name_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(231, 242, 255);
        }

        private void gunaPicture_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }
    }
}
