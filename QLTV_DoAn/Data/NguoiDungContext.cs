using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLTV_DoAn.Models;

namespace QLTV_DoAn.Data
{
    public class NguoiDungContext : DbContext
    {
        public NguoiDungContext (DbContextOptions<NguoiDungContext> options)
            : base(options)
        {
        }

        public DbSet<QLTV_DoAn.Models.NguoiDung> NguoiDung { get; set; } = default!;
    }
}
