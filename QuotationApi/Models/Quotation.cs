using System;
using System.ComponentModel.DataAnnotations;

namespace QuotationApi.Models
{
    public class Quotation
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "")]
        public string QuotationText { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
    }
}