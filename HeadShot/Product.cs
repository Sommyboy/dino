using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadShot
{
    class Product
    {

        string name;
        string type;
        string tags;
        string category;
        int price;
        string description;


        void setName(string name) { this.name = name; }
        string getName() { return this.name; }

        void setType(string typ) { this.type = typ; }
        string getDate() { return this.type; }

        void setTags(string tag) { this.tags = tag; }
        string getTags() { return this.tags; }

        void setCategory(string cat) { this.category = cat; }
        string getCategory() { return this.category; }

        void setPrice(int pri) { this.price = pri; }
        int getPrice() { return this.price; }

        void setDescription(string desc) { this.description = desc; }
        string getDescription() { return this.description; }



    }
}
