using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexKassa.Core
{
    public class CheckOrderRequest
    {
        public DateTime requestDatetime { get; set; }
        public long shopId { get; set; }
        public long shopArticleId { get; set; }
        /// <summary>
        /// Уникальный номер транзакции в ИС Оператора.
        /// </summary>
        public long invoiceId { get; set; }

        public string orderNumber { get; set; }

        public string customerNumber { get; set; }
        public DateTime orderCreatedDatetime { get; set; }
        public decimal orderSumAmount { get; set; }
        public int orderSumCurrencyPaycash { get; set; }
        public int orderSumBankPaycash { get; set; }
        public decimal shopSumAmount { get; set; }
        public int shopSumCurrencyPaycash { get; set; }
        public int shopSumBankPaycash { get; set; }
        public string paymentPayerCode { get; set; }
        public string paymentType { get; set; }


    }
}
