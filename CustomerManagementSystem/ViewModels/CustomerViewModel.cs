using CustomerManagementSystem.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }


        [DisplayName("Customer Name")]
        [Required(ErrorMessage ="Please provide valid Customer Name")]
        public required string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please provide valid Customer Email Address")]
        [EmailAddress]
        public required string Email { get; set; } = string.Empty;

        [DisplayName("Address")]
        public string Address { get; set; } = string.Empty;

        [DisplayName("City")]
        public string City { get; set; } = string.Empty;

        [DisplayName("Region")]
        public string Region { get; set; } = string.Empty;

        [DisplayName("PostalCode")]
        public string PostalCode { get; set; } = string.Empty;

        [DisplayName("Country")]
        public string Country { get; set; } = string.Empty;

        [DisplayName("PhoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DisplayName("Fax")]
        public string Fax { get; set; } = string.Empty;

        [DisplayName("VatNumber")]
        public string VATNumber { get; set; } = string.Empty;

        public Customer Customer { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
