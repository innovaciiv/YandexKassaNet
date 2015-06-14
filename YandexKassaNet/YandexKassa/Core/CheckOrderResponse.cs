using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexKassa.Core
{
    public class CheckOrderResponse
    {
        public DateTime performedDatetime { get; set; }
        public int code { get; set; }
        public long shopId { get; set; }
        public long invoiceId { get; set; }
        public decimal orderSumAmount { get; set; }

        public string message { get; set; }
        public string techMessage { get; set; }
    }
}
