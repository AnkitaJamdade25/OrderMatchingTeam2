using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_matching
{
    class Trade
    {
        private long tradeId { get; set; }
        private int buyId { get; set; }
        private int sellId { get; set; }
        private string ISIN { get; set; }
        private float Price { get; set; }
        private int Quantity { get; set; }
        private DateTime dt { get; set; }

        public Trade()
        {
            tradeId = buyId = sellId = -1;
            ISIN = "";
            Price = 0;
            Quantity = 0;

        }

        //tradeId
        public long gettradeId()
        {
            return tradeId;
        }

        public void settradeId(long tradeId)
        {
            this.tradeId = tradeId;
        }

        //buyId
        public int getbuyId()
        {
            return buyId;
        }

        public void setbuyId(int buyId)
        {
            this.buyId = buyId;
        }


        //sellId
        public int getsellId()
        {
            return sellId;
        }

        public void setsellId(int sellId)
        {
            this.sellId = sellId;
        }

        //ISIN
        public String getISIN()
        {
            return ISIN;
        }

        public void setISIN(String ISIN)
        {
            this.ISIN = ISIN;
        }


        //price
        public float getPrice()
        {
            return Price;
        }

        public void setPrice(float Price)
        {
            this.Price = Price;
        }

        //quantity
        public int getQuantity()
        {
            return Quantity;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        //dt
        public DateTime getdt()
        {
            return dt;
        }

        public void setdt(DateTime dt)
        {
            this.dt = dt;
        }

    }
}
