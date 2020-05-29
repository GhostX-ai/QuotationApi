using System;
using System.ComponentModel.DataAnnotations;

namespace QuotationApi.Models
{
    public class Quotation
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "This column can not be empty")]
        public string QuotationText { get; set; }
        public string Author { get; set; }
        
        [Required(ErrorMessage = "This column can not be empty")]
        public DateTime PubDate { get; set; }
    }
}