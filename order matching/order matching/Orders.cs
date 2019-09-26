using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_matching
{
    class Orders
    {
        private int Id;
        private string ISIN;
        private DateTime dt;
        private string Type;
        private int Quantity;
        private float Price;
        private float Brokerage;
        private float Min_Quantity;
        private string Action;
        private DateTime execTime;

        public Orders()
        {

        }

        public void setId(int Id)
        {
            this.Id = Id;
        }
        public int getId()
        {
            return Id;
        }
        public void setISIN(string ISIN)
        {
            this.ISIN = ISIN;
        }
        public string getISIN()
        {
            return ISIN;
        }
        public void setDatetime(DateTime dt)
        {
            this.dt = dt;
        }
        public DateTime getDatetime()
        {
            return dt;
        }

        public void setType(string Type)
        {
            this.Type = Type;
        }
        public string getType()
        {
            return Type;
        }
        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public int getQuantity()
        {
            return Quantity;
        }
        public void setPrice(float Price)
        {
            this.Price = Price;
        }
        public float getPrice()
        {
            return Price;
        }
        public void setBrokerage(float Brokerage)
        {
            this.Brokerage = Brokerage;
        }
        public float getBrokerage()
        {
            return Brokerage;
        }
        public void setMin_Quantity(float Min_Quantity)
        {
            this.Min_Quantity = Min_Quantity;
        }
        public float getMin_Quantity()
        {
            return Min_Quantity;
        }

        public void setAction(string Action)
        {
            this.Action = Action;
        }
        public string getAction()
        {
            return Action;
        }

        public void setexecTime(DateTime execTime)
        {
            this.execTime = execTime;
        }
        public DateTime getexecTime()
        {
            return execTime;
        }
        public override string ToString()
        {
            return $"\nId:{Id}\nISIN: {ISIN}\nDate: {dt}\nType: {Type}\nQuantity: {Quantity}\nPrice: {Price}\nBrokerage: {Brokerage}\nMin_Quantity:{Min_Quantity}";
                

        }



    }
}
