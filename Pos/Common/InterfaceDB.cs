using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Common
{
    class InterfaceDB
    {
    }
    public class Item
    {
        public string ID_Item;
        public string Name;
        public string ID_Categories;
        public double Price;

        public Item()
        {

        }

        public Item(object ID_Item,
        object Name,
        object ID_Categories,
        object Price)
        {
            this.ID_Item = ID_Item.ToString();
            this.Name = Name.ToString();
            this.ID_Categories = ID_Categories.ToString();
            this.Price = double.Parse(Price.ToString());
        }
    }

    public class Categories
    {
        public string id;
        public string name;

        public Categories() { }
        public Categories(object id, object name)
        {
            this.id = id.ToString();
            this.name = name.ToString();
        }
    }
}
