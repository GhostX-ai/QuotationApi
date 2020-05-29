using System;
using Microsoft.EntityFrameworkCore;

namespace QuotationApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Quotation> Quotations { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Quotation>().HasData(
                new Quotation(){
                    Id = 1,
                    Author = "Aziz",
                    QuotationText = "Да прибудет с тобой сила, мой юный падаван",
                    PubDate = DateTime.Parse("05/29/2020")
                },
                new Quotation(){
                    Id = 2,
                    Author = "Khurshed",
                    QuotationText = "Не надо мелочиться, нужно рубить с корня",
                    PubDate = DateTime.Parse("05/30/2020")
                },
                new Quotation(){
                    Id = 3,
                    Author = "Firdavs",
                    QuotationText = "Французишь друг мой",
                    PubDate = DateTime.Parse("02/29/2020")
                },
                new Quotation(){
                    Id = 4,
                    Author = "Shahzod",
                    QuotationText = "Kali лучше чем parrot",
                    PubDate = DateTime.Parse("04/20/2020")
                },
                new Quotation(){
                    Id = 5,
                    Author = "Amin",
                    QuotationText = "Много поколений процессоров не бывает",
                    PubDate = DateTime.Parse("04/20/2020")
                }
            );
        }
    }
}