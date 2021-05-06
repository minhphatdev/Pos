using Connect;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos.Components
{
    public partial class CpOrder : UserControl
    {
        int selected = 0;

        Guna.UI.Lib.ScrollBar.PanelScrollHelper vsCroll = null;

        RegionBAL region = new RegionBAL();
        DataSet dsItem = new DataSet();
        DataSet dsCategories = new DataSet();

        Common.Item[] DsItem = null;
        Common.Categories[] DSCategories = null;

        Order.Card[] eDSCategories = null;

        GunaPanel store = new GunaPanel();


        public delegate void setTotalMoney(double io);
        setTotalMoney ol = null;

        List<Order.Store> itemStore = new List<Order.Store>();
        public CpOrder(ref Guna.UI.Lib.ScrollBar.PanelScrollHelper sr, GunaVScrollBar sc,ref GunaPanel store, setTotalMoney totalMoney)
        {
            ol = totalMoney;
            InitializeComponent();
            DoubleBuffered = true;

            vsCroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panelMain, gunaScroll, true);
            vsCroll.UpdateScrollBar();

            initPanelTop();
            initPanelMain();


            sr = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(this.store, sc, true);

            store.Controls.Add(this.store);
            this.store.Dock = DockStyle.Fill;
        }

        private void initPanelMain()
        {
            getItem();
            panelMain.Controls.Clear();


            int len = DsItem.Length;
            int col = 6;
            int row = 0;
            int width = (1468 / col) - 3;
            for (int i = 1; i <= len; i++)
            {
                int index = i - 1;
                var test = new Order.OdderCard(DsItem[index], width, width * ((i - 1) % col) + 10, 297 * row, (o, k) => addItem(DsItem[index]));
                if (i % col == 0)
                {
                    row++;
                }
                panelMain.Controls.Add(test);
            }
        }

        public void getItem()
        {
            if (selected == 0)
            {
                dsItem = region.getAllItem();
            }
            else
            {
                var sd = DSCategories[selected - 1].id;
                dsItem = region.getItemByType(sd.ToString());
            }


            var dbItem = dsItem.Tables[0];
            int lenDbItem = dbItem.Rows.Count;
            DsItem = null;
            DsItem = new Common.Item[lenDbItem];
            int flag = 0;
            foreach (DataRow index in dbItem.Rows)
            {
                var item = index.ItemArray;
                DsItem[flag++] = new Common.Item(item[0], item[1], item[2], item[3]);
            }
        }

        public void initPanelTop()
        {
            dsCategories = region.getCategories();
            var dbItem = dsCategories.Tables[0].Rows;
            int len = dbItem.Count;

            DSCategories = new Common.Categories[len];
            eDSCategories = new Order.Card[len + 1];
            int width = (1463 / len) - 2;
            bool active;

            active = selected == 0 ? true : false;

            eDSCategories[0] = new Order.Card(active, "01", "Tất cả", width, width * (0) + 10, (o, k) => clearPanelTop(int.Parse("0")));
            for (int i = len; i > 0; i--)
            {
                string number = string.Concat("0", i);
                active = selected == i ? true : false;
                var item = dbItem[i - 1].ItemArray;

                DSCategories[i - 1] = new Common.Categories(item[0], item[1]);

                eDSCategories[i] = new Order.Card(active, number, item[1].ToString(), width, width * (i - 1) + 10, (o, k) => clearPanelTop(int.Parse(number)));
            }

            foreach (Order.Card item in eDSCategories)
            {
                panelTop.Controls.Add(item);
            }
        }

        public void clearPanelTop(int data)
        {
            if (data != selected)
            {
                eDSCategories[selected].unSelectived();
                selected = data;
                eDSCategories[selected].selectived();
                initPanelMain();
            }
        }


        public void addItem(Common.Item item)
        {
            if (itemStore.Count == 0)
            {
                itemStore.Add(new Order.Store( item, delItem));
                store.Controls.Add(itemStore[itemStore.Count - 1]);
                itemStore[itemStore.Count - 1].Dock = DockStyle.Top;
                getTotalMoney();
                return;
            }

            foreach (Order.Store it in itemStore)
            {
                if (it.id == item.ID_Item)
                {
                    it.setCount();
                    getTotalMoney();
                    return;
                }

            }
            itemStore.Add(new Order.Store( item, delItem));
            store.Controls.Add(itemStore[itemStore.Count - 1]);
            itemStore[itemStore.Count - 1].Dock = DockStyle.Top;
            getTotalMoney();
        }

        public void getTotalMoney()
        {
            double total = 0;
            foreach (Order.Store it in itemStore)
            {
                total += it.priceE;
            }
            ol(total);
        }

      public void delItem(string id)
        {
            for(int i =0;i< itemStore.Count;i++)
            {
                if (itemStore[i].id == id)
                { 
                    store.Controls.Remove(itemStore[i]);
                    itemStore.RemoveAt(i);
                    getTotalMoney();
                    return;
                }    
                   
            }    
        }
    }
}
