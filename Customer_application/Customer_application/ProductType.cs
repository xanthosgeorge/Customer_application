using System;
using DevExpress.Xpo;

namespace Customer_application
{

    public class ProductType : XPObject
    {

        string productTypeDescription;

        
        [Association("ProductType-Products")]
        public XPCollection<Product> Products
        {
            get { return GetCollection<Product>("Products"); }
        }

                
            

        public string ProductTypeDescription
        {
            get { return productTypeDescription; }
            set { SetPropertyValue<string>("ProductTypeDescription", ref productTypeDescription, value); }
        }

      

        public ProductType()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ProductType(Session session)
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