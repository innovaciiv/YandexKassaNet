using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexKassa.Core
{
    /// <summary>
    /// Способы оплаты
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// rus: Оплата из кошелька в Яндекс.Деньгах.
        /// </summary>
        PC,
        /// <summary>
        /// rus: Оплата с произвольной банковской карты.
        /// </summary>
        AC,
        /// <summary>
        /// rus: Платеж со счета мобильного телефона.
        /// </summary>
        MC,
        /// <summary>
        /// rus: Оплата наличными через кассы и терминалы.
        /// </summary>
        GP,
        /// <summary>
        /// rus: Оплата из кошелька в системе WebMoney.
        /// </summary>
        WM,
        /// <summary>
        /// rus: Оплата через Сбербанк: оплата по SMS или Сбербанк Онлайн.
        /// </summary>
        SB,
        /// <summary>
        /// rus: Оплата через мобильный терминал (mPOS).
        /// </summary>
        MP,
        /// <summary>
        /// rus: Оплата через Альфа-Клик.
        /// </summary>
        AB,
        /// <summary>
        /// rus: Оплата через MasterPass.
        /// </summary>
        МА,
        /// <summary>
        /// rus: Оплата через Промсвязьбанк.
        /// </summary>
        PB
    }
}
