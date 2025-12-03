using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class InsureeData : DbContext
    {
        public InsureeData(DbContextOptions<InsureeData> options) : base(options)
        {
            
        }


        public DbSet<Insuree> Insurees { get; set; }    
    }
}