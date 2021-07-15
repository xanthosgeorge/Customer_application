using System;
using DevExpress.Xpo;

namespace Customer_application
{

    public class Customer : XPObject
    {

        string customerName;
        string customerAddress;

        public string CustomerName
        {
            get { return customerName; }
            set { SetPropertyValue<string>("CustomerName", ref customerName, value); }

        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set {SetPropertyValue<string>("CustomerAddress", ref customerAddress , value);}
        }

        [Association("Customer-Order")]
        public XPCollection<Order> Order
        {
            get { return GetCollection<Order> ("Order"); }
        }
        public Customer()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Customer(Session session)
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