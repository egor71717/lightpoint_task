using Lightpoint.Task.DAL.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lightpoint.Task.DAL.Entities
{
    [Serializable]
    public class Product: IDataEntity
    {
        private Int32 id;
        private String name;
        private String description;
        private Int32 shopId;

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

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        [ForeignKey("Shop")]
        public Int32 ShopId
        {
            get { return shopId; }
            set { shopId = value; }
        }

        public virtual Shop Shop { get; set; }
    }
}
