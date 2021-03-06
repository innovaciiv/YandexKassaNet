﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexKassa.Core
{
    /// <summary>
    /// Платежная форма
    /// </summary>
    public class PayForm
    {
        /// <summary>
        /// rus: Идентификатор Контрагента, выдается Оператором.
        /// </summary>
        public long shopId { get; set; }
        /// <summary>
        /// rus: Идентификатор товара, выдается Оператором. Применяется, если Контрагент использует 
        /// несколько платежных форм для разных товаров.
        /// </summary>
        public long? shopArticleId { get; set; }
        /// <summary>
        /// rus: Номер витрины Контрагента, выдается Оператором.
        /// </summary>
        public long scid { get; set; }
        /// <summary>
        /// rus: Стоимость заказа.
        /// </summary>
        public decimal sum { get; set; }
        /// <summary>
        /// rus: Идентификатор плательщика в ИС Контрагента. В качестве идентификатора может использоваться номер 
        /// договора плательщика, логин плательщика и т. п. Возможна повторная оплата по одному и тому же 
        /// идентификатору плательщика.
        /// </summary>
        public string customerNumber { get; set; }
        /// <summary>
        /// rus: Уникальный номер заказа в ИС Контрагента. Уникальность контролируется Оператором 
        /// в сочетании с параметром shopId. Если платеж с таким номером заказа уже был успешно 
        /// проведен, то повторные попытки оплаты будут отвергнуты Оператором.
        /// </summary>
        public string orderNumber { get; set; }
        /// <summary>
        /// rus: URL, на который нужно отправить плательщика в случае успеха перевода. 
        /// Используется при выборе соответствующей опции подключения Контрагента 
        /// (см. раздел 6.1 «Параметры подключения Контрагента»).
        /// </summary>
        public string shopSuccessURL { get; set; }
        /// <summary>
        /// rus: URL, на который нужно отправить плательщика в случае ошибки оплаты. 
        /// Используется при выборе соответствующей опции подключения Контрагента.
        /// </summary>
        public string shopFailURL { get; set; }
        /// <summary>
        /// rus: Адрес электронной почты плательщика. Если он передан, то соответствующее поле на 
        /// странице подтверждения платежа будет предзаполнено (шаг 3 на схеме выше).
        /// </summary>
        public string cps_email { get; set; }
        /// <summary>
        /// rus: Номер мобильного телефона плательщика. Если он передан, то соответствующее 
        /// поле на странице подтверждения платежа будет предзаполнено (шаг 3 на схеме выше). 
        /// Номер телефона используется при оплате наличными через терминалы.
        /// </summary>
        public string cps_phone { get; set; }
        /// <summary>
        /// rus: Способ оплаты. По умолчанию PC
        /// </summary>
        public string paymentType { get; set; }
    }
}
