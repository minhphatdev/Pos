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
    public partial class Store : UserControl
    {
        public string id;
        private int countE = 1;
        private double priceS;
        public double priceE;

        public delegate void delItem(string id);
        delItem del=null;
        public Store( Common.Item item, delItem ol)
        {
            InitializeComponent();
            del = ol;



            id = item.ID_Item;
            name.Text = item.Name;
            priceS = item.Price;
            priceE = item.Price;
            price.Text = string.Format("{0:0,0}đ", item.Price);
            count.Text = countE.ToString();
        }

        public int getCout()
        {
            return countE;
        }

        public void setCount()
        {
            countE = countE +1;
            priceE = priceS * countE;
            count.Text = countE.ToString();
            price.Text = string.Format("{0:0,0}đ", priceE);
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            del(id);
        }
    }
}
