using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model;
using System;
using System.Collections.Generic;

namespace BooksAndVideosShop.Core.Services
{
    public class PurchaseOrderProcessor : IPurchaseOrderProcessor
    {

        private readonly List<IBusinessRule> _businessRules;

        public PurchaseOrderProcessor(List<IBusinessRule> businessRules)
        {
            _businessRules = businessRules;
        }

        public void Process(IPurchaseOrder purchaseOrder)
        {
            if (purchaseOrder == null)
            {
                throw new ArgumentException("order cannot be null");
            }

            if (purchaseOrder.LineItems == null)
            {
                throw new ArgumentException("line items cannot be null");
            }

            foreach (var lineItem in purchaseOrder.LineItems)
            {
                ProcessLineItem(purchaseOrder.PurchaseOrderId, purchaseOrder.CustomerId, lineItem);
            }
        }

        private void ProcessLineItem(long orderId, long customerTd, Product lineItem)
        {
            _businessRules.ForEach(b => b.Apply(orderId, customerTd, lineItem));

        }
    }
}
