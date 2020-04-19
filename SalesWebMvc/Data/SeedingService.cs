using SalesWebMvc.Models;
using System.Linq;
using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Joselma Maria", "joselma@gmail.com", new DateTime(1999, 1, 11), 6000.0, d2);
            Seller s3 = new Seller(3, "Jose Rodrigues", "jose@gmail.com", new DateTime(1993, 7, 27), 3000.0, d3);
            Seller s4 = new Seller(4, "Maria Cristina", "maria@gail.com", new DateTime(1992, 11, 22), 2000.0, d4);
            Seller s5 = new Seller(5, "Rachel Atah", "rachel@gmail.com", new DateTime(1995, 1, 31), 1000.0, d1);
            Seller s6 = new Seller(6, "Carlito luis", "carlito@gmail.com", new DateTime(1992, 2, 05), 2000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 07, 19), 15000.0, SaleStatus.Billed, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 06, 17), 16000.0, SaleStatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 05, 15), 18000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 10, 03), 15000.0, SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 11, 06), 13000.0, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 03, 03), 14000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 30), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 02, 28), 13000.0, SaleStatus.Billed, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 08,15), 18000.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 07,20 ), 16000.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 12, 08), 14000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);


            _context.SaveChanges();






        }
    }
}
