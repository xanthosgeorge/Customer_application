using System;
using DevExpress.Xpo;

namespace Customer_application
{

    public class Product : XPObject
    {
        string productCode;
        string productDescription;
        
        public string ProductCode
        {
            get { return productCode; }
            set { SetPropertyValue<string>("ProductCode", ref productCode, value); }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { SetPropertyValue<string>("ProductDescription", ref productDescription, value); }
        }
        
        private ProductType _productType;
        [Association("ProductType-Products")]
        public ProductType ProductType
        {
            get { return _productType; }
            set { SetPropertyValue<ProductType>("ProductType", ref _productType, value); }
        }

        [Association("Product-Order")]
        public XPCollection<Order> Order
        {
            get { return GetCollection<Order>("Order"); }
        }
        public Product()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Product(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}