using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface IInvoiceService
    {
        /// <summary>
        /// Get total invoices of the given provider ID
        /// </summary>
        /// <param name="id">Provider's id</param>
        /// <returns></returns>
        Task<IEnumerable<Invoice>> GetInvoicesByProvider(Guid id);

        /// <summary>
        /// Creates a new invoice. 
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="taker"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<Invoice> CreateInvoice(Invoice invoice, Taker taker, Address address);

        /// <summary>
        /// Reads an invoice with a given id
        /// </summary>
        /// <param name="id">Invoice id</param>
        /// <returns></returns>
        Task<Invoice> ReadInvoice(Guid id);
        /// <summary>
        /// Updates an invoice
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="taker"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<Invoice> UpdateInvoice(Invoice invoice, Taker taker, Address address);
        /// <summary>
        /// Tries to remove an invoice from the system
        /// </summary>
        /// <param name="id">Invoice id</param>
        /// <returns> If its in the legal date, it will return the invoice, if not, returns null </returns>
        Task<bool> DeleteInvoice(Guid id);

        /// <summary>
        /// Get all invoices from the system
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Invoice>> GetAll();
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        Task<List<int>> GetInvoiceMonths();

        /// <summary>
        /// Return the total income of the provider for the API controller.
        /// </summary>
        Task<decimal> GetProviderTotalIncome();
    }
}