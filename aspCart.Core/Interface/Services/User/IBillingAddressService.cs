﻿using System;
using aspCart.Core.Domain.User;

namespace aspCart.Core.Interface.Services.User
{
    public interface IBillingAddressService
    {
        /// <summary>
        /// Get billing address by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Billing address entity</returns>
        BillingAddress GetBillingAddressById(Guid id);

        /// <summary>
        /// Insert billing address
        /// </summary>
        /// <param name="billingAddress">Billing address entity</param>
        void InsertBillingAddress(BillingAddress billingAddress);

        /// <summary>
        /// Update billing address
        /// </summary>
        /// <param name="billingAddress">Billing address entity</param>
        void UpdateBillingAddress(BillingAddress billingAddress);
    }
}