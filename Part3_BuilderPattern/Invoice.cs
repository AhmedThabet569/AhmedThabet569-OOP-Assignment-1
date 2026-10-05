using BuilderPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public string BillingCountry { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZipCode { get; set; }
        public string ShippingCountry { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount =>
      SubTotal - DiscountAmount + TaxAmount;
    }

    public class InnvoiceBuilder
    {

        //private invoice 

        private int _invoiceId;
        private string _CustomerName;
        private string _CustomerEmail;
        private string _CustomerPhone;

        //opetional parameters
        public string _billingStreet;
        public string _billingCity;
        public string _billingState;
        public string _billingZipCode;
        public string _billingCountry;

        //shipping address
        public string _shippingStreet;
        public string _shippingCity;
        public string _shippingState;
        public string _shippingZipCode;
        public string _shippingCountry;

        //order details
        public DateTime _orderDate;
        public string _paymentMethod;
        public string _currency;

        //total amount
        public decimal _subTotal;
        public decimal _discountAmount;
        public decimal _taxAmount;

        public InnvoiceBuilder SetInvoiceId(int invoiceId)
        {
            _invoiceId = invoiceId;
            return this;
        }
        public InnvoiceBuilder SetInvoiceMainDetails(string customerName, string customerEmail, string customerPhone)
        {
            _CustomerName = customerName;
            _CustomerEmail = customerEmail;
            _CustomerPhone = customerPhone;
            return this;
        }
        public InnvoiceBuilder SetBillingAddress(string billingStreet, string billingCity, string billingState, string billingZipCode, string billingCountry)
        {
            _billingStreet = billingStreet;
            _billingCity = billingCity;
            _billingState = billingState;
            _billingZipCode = billingZipCode;
            _billingCountry = billingCountry;
            return this;
        }
        public InnvoiceBuilder SetShippingAddress(string shippingStreet, string shippingCity, string shippingState, string shippingZipCode, string shippingCountry)
        {
            _shippingStreet = shippingStreet;
            _shippingCity = shippingCity;
            _shippingState = shippingState;
            _shippingZipCode = shippingZipCode;
            _shippingCountry = shippingCountry;
            return this;
        }
        public InnvoiceBuilder SetOrderDetails(DateTime orderDate, string paymentMethod, string currency)
        {
            _orderDate = orderDate;
            _paymentMethod = paymentMethod;
            _currency = currency;
            return this;
        }
        public InnvoiceBuilder CalculateTotalAmount(decimal SubTotal, decimal DiscountAmount, decimal TaxAmount)
        {
            _subTotal = SubTotal;
            _discountAmount = DiscountAmount;
            _taxAmount = TaxAmount;
            return this;
        }
        public Invoice Build()
        {
            return new Invoice
            {
                InvoiceId = _invoiceId,
                CustomerName = _CustomerName,
                CustomerEmail = _CustomerEmail,
                CustomerPhone = _CustomerPhone,
                BillingStreet = _billingStreet,
                BillingCity = _billingCity,
                BillingState = _billingState,
                BillingZipCode = _billingZipCode,
                BillingCountry = _billingCountry,
                ShippingStreet = _shippingStreet,
                ShippingCity = _shippingCity,
                ShippingState = _shippingState,
                ShippingZipCode = _shippingZipCode,
                ShippingCountry = _shippingCountry,
                OrderDate = _orderDate,
                PaymentMethod = _paymentMethod,
                Currency = _currency,
                SubTotal = _subTotal,
                DiscountAmount = _discountAmount,
                TaxAmount = _taxAmount,
            };
        }
    }
}

