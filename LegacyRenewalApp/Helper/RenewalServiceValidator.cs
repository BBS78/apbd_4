using LegacyRenewalApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyRenewalApp.Helper
{
    internal class RenewalServiceValidator : IRenewalServiceValidator
    {
        void IRenewalServiceValidator.Validate(int customerId, string planCode, int seatCount, string paymentMethod)
        {
            if (customerId <= 0)
            {
                throw new ArgumentException("Customer ID must be a positive integer", nameof(customerId));
            }
            if (string.IsNullOrWhiteSpace(planCode))
            {
                throw new ArgumentException("Plan code cannot be null or empty", nameof(planCode));
            }
            if (seatCount <= 0)
            {
                throw new ArgumentException("Seat count must be a positive integer", nameof(seatCount));
            }
            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                throw new ArgumentException("Payment method cannot be null or empty", nameof(paymentMethod));
            }
        }
    }
}
