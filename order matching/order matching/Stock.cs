using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_matching
{
    class Stock
    {

        private string ISIN { get; set; }
        private string stockName { get; set; }
        private float CMP { get; set; }
        private float LTP { get; set; }
        private float High { get; set; }
        private float Low { get; set; }
        private float Closed { get; set; }
        private long Volume { get; set; }

        public Stock()
        {
            ISIN = "";
            stockName = null;
            CMP = LTP = High = Low = Closed = Volume = 0;
        }

        public string getISIN()
        {
            return ISIN;
        }
        public void setISIN(String ISIN)
        {
            this.ISIN = ISIN;
        }

        public string getstockName()
        {
            return stockName;
        }
        public void setstockName(String stockName)
        {
            this.stockName = stockName;
        }

        public float getCMP()
        {
            return CMP;
        }
        public void setCMP(float CMP)
        {
            this.CMP = CMP;
        }

        public float getLTP()
        {
            return LTP;
        }
        public void setLTP(float LTP)
        {
            this.LTP = LTP;
        }

        public float getHigh()
        {
            return High;
        }
        public void setHigh(float High)
        {
            this.High = High;
        }

        public float getLow()
        {
            return Low;
        }
        public void setLow(float Low)
        {
            this.Low = Low;
        }

        public float getClosed()
        {
            return Closed;
        }
        public void setClosed(float Closed)
        {
            this.Closed = Closed;
        }

        public long getVolume()
        {
            return Volume;
        }
        public void setVolume(long Volume)
        {
            this.Volume = Volume;
        }


    }
}
