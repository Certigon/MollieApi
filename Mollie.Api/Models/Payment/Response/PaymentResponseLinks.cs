﻿using System.Collections.Generic;
using Mollie.Api.Models.Chargeback;
using Mollie.Api.Models.Customer;
using Mollie.Api.Models.List;
using Mollie.Api.Models.List.Specific;
using Mollie.Api.Models.Mandate;
using Mollie.Api.Models.Refund;
using Mollie.Api.Models.Settlement;
using Mollie.Api.Models.Subscription;
using Mollie.Api.Models.Url;

namespace Mollie.Api.Models.Payment.Response {
    public class PaymentResponseLinks {
        /// <summary>
        /// The API resource URL of the payment itself.
        /// </summary>
        public UrlObjectLink<PaymentResponse> Self { get; set; }

        /// <summary>
        /// The URL your customer should visit to make the payment. This is where you should redirect the consumer to.
        /// </summary>
        public UrlLink Checkout { get; set; }

        /// <summary>
        /// The API resource URL of the refunds that belong to this payment.
        /// </summary>
        public UrlLink Refunds { get; set; }

        /// <summary>
        /// The API resource URL of the chargebacks that belong to this payment.
        /// </summary>
        public UrlObjectLink<ListResponse<ChargebackListData>> Chargebacks { get; set; }

        /// <summary>
        /// The API resource URL of the settlement this payment has been settled with. Not present if not yet settled.
        /// </summary>
        public UrlObjectLink<SettlementResponse> Settlement { get; set; }

        /// <summary>
        /// The URL to the payment retrieval endpoint documentation.
        /// </summary>
        public UrlLink Documentation { get; set; }

        /// <summary>
        /// The API resource URL of the mandate linked to this payment. Not present if a one-off payment.
        /// </summary>
        public UrlObjectLink<MandateResponse> Mandate { get; set; }

        /// <summary>
        /// The API resource URL of the subscription this payment is part of. Not present if not a subscription payment.
        /// </summary>
        public UrlObjectLink<SubscriptionResponse> Subscription { get; set; }

        /// <summary>
        /// The API resource URL of the customer this payment belongs to. Not present if not linked to a customer.
        /// </summary>
        public UrlObjectLink<CustomerResponse> Customer { get; set; }
    }
}