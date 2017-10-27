using Lightpoint.Task.DAL.Interface;
using System;
using System.Collections.Generic;


namespace Lightpoint.Task.DAL.Entities
{
    
    [Serializable]
    public class Shop : IDataEntity
    {
        private Int32 id;
        private String name;
        private String adress;
        private String mode;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public String Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}
