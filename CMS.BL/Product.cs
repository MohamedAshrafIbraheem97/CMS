﻿using Additional.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Product : EntityBase , ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }


        public int ProductId { get; private set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
                
            }

            set { _productName = value; }
        }



        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }


        public string log() => $"{ProductId} , {ProductName} : {Description}";
    }
}
