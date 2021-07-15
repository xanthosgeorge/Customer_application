using System;
using DevExpress.Xpo;

namespace Customer_application
{

    public class Order : XPObject
    {
        private Customer _customer;
        private Product _product;
        DateTime orderDate;
        int quantity;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { SetPropertyValue<DateTime>("OrderTime", ref orderDate, value); }

        }

        public int Quantity
        {
            get { return quantity; }
            set { SetPropertyValue<int>("Quantity", ref quantity, value); }
        }

        [Association("Customer-Order")]
        public Customer Customer
        {
            get { return _customer;}
            set { SetPropertyValue<Customer>("Customer", ref _customer, value); }
        }
      
        [Association("Product-Order")]
        public Product Product
        {
            get { return _product; }
            set {SetPropertyValue<Product>("Product", ref _product , value);}
        }

       


        public Order()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Order(Session session)
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
        protected override void OnSaving()
        {
            base.OnSaving();
            if (_customer == null)
                Delete();
        }
    }

}