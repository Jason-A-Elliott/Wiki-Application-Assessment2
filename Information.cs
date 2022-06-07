using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki_Prototype_Application
{
    
     //6.1 Create a separate class file to hold the four data items of the Data Structure 
    class Information : IComparable
    {
        string name;
        string category; 
        string structure; 
        string definition;
        bool bstructure;
        public Information()
        {
            Information info = new Information("Name", "Array", true, "Definition");

        }
        public Information(string Name, string Category, bool Structure, string Definition)
        {
            setName(Name);
            setCategory(Category);
            setbStructure(Structure);
            setDefinition(Definition);
            if (Structure)
            {
                setStructure("linear");
            }
            else
            {
                setStructure("non-linear");
            }
        }
        public int CompareTo(Object info)
        {

            if (info == null)
            {return 1;}
            if (info != null)
            {
                return getName().CompareTo(((Information)info).getName());
            }
            else
            {
                return 0;
            }
        }
        public void setName(string Name)
        {
            this.name = Name;
        }
        public void setCategory(string Category)
        {
            this.category = Category;
        }
        public void setbStructure(bool bStructure)
        {
            this.bstructure = bStructure;
        }
        public void setStructure(string Structure)
        {
            this.structure = Structure;
        }
        public void setDefinition(string Definition)
        {
            this.definition = Definition;
        }
        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public bool getbStructure()
        {
            return bstructure;
        }
        
        public string getStructure()
        {
            return structure;
        }
        public string getDefinition()
        {
            return definition;
        }
    }
}

