using Microsoft.EntityFrameworkCore;
using WebApiFinalSandovalCarla.Models;


namespace WebApiFinalSandovalCarla.Data
{
    public class DBHospitalAPIContext:DbContext
    {
        //CORE declaracion del constructor 
        public DBHospitalAPIContext(DbContextOptions<DBHospitalAPIContext> options) : base(options) { }

        //DBSET
        public DbSet<Doctor> Doctores { get; set; }

        public DbSet<Hospital> Hospitales { get; set; }
        

    }
}
