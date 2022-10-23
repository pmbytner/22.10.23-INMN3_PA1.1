using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _22._10._23_INMN3_PA1._1.Models;

namespace _22._10._23_INMN3_PA1._1.Data
{
    public class _22_10_23_INMN3_PA1_1Context : DbContext
    {
        public _22_10_23_INMN3_PA1_1Context (
            DbContextOptions<_22_10_23_INMN3_PA1_1Context> options
            )
            : base(options)
        {
        }

        public DbSet<_22._10._23_INMN3_PA1._1.Models.Państwo>
            Państwa { get; set; } = default!;
    }
}
