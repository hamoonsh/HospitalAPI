
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

namespace HospitalAPI.Models.Entities
{
    public class HospitalDBContext : DbContext
    {
        private IConfiguration _config;
        public HospitalDBContext(IConfiguration config) : base()
        {
            _config = config;
        }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HospitalDoctor> HospitalDoctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hospital>().HasData(
           new Hospital
           {
               HospitalID = 1,
               levelZeroVisitingTime = 5,
               levelOneVisitingTime = 7,
               levelTwoVisitingTime = 16,
               levelThreeVisitingTime = 30,
               levelFourVisitingTime = 38,
               Name = "Hospital A"
           },
            new Hospital
            {
                HospitalID = 2,
                levelZeroVisitingTime = 10,
                levelOneVisitingTime = 11,
                levelTwoVisitingTime = 15,
                levelThreeVisitingTime = 20,
                levelFourVisitingTime = 29,
                Name = " Hospital B"
            },
             new Hospital
             {
                 HospitalID = 3,
                 levelZeroVisitingTime = 15,
                 levelOneVisitingTime = 18,
                 levelTwoVisitingTime = 20,
                 levelThreeVisitingTime = 20,
                 levelFourVisitingTime = 30,
                 Name = "Hospital C"
             },
             new Hospital
             {
                 HospitalID = 4,
                 levelZeroVisitingTime = 10,
                 levelOneVisitingTime = 10,
                 levelTwoVisitingTime = 15,
                 levelThreeVisitingTime = 20,
                 levelFourVisitingTime = 28,
                 Name = "Hospital D"
             },
             new Hospital
             {
                 HospitalID = 5,
                 levelZeroVisitingTime = 18,
                 levelOneVisitingTime = 20,
                 levelTwoVisitingTime = 20,
                 levelThreeVisitingTime = 25,
                 levelFourVisitingTime = 32,
                 Name = "Hospital E"
             },
             new Hospital
             {
                 HospitalID = 6,
                 levelZeroVisitingTime = 12,
                 levelOneVisitingTime = 20,
                 levelTwoVisitingTime = 30,
                 levelThreeVisitingTime = 32,
                 levelFourVisitingTime = 38,
                 Name = "Hospital F"
             });

            modelBuilder.Entity<Doctor>().HasData(

                new Doctor { DoctorID = 1, Name = "Javad", Family = "Javadi" },
                new Doctor { DoctorID = 2, Name = "Javid", Family = "Javidi" },
                new Doctor { DoctorID = 3, Name = "Mahdi", Family = "Mahdavi" },
                new Doctor { DoctorID = 4, Name = "Kamran", Family = "kamrani" },
                new Doctor { DoctorID = 5, Name = "Soheil", Family = "Soheili" },
                new Doctor { DoctorID = 6, Name = "Ali", Family = "Alavi" });

            modelBuilder.Entity<HospitalDoctor>().HasData(
                new HospitalDoctor { HospitalDoctorID = 1, DoctorID = 1, HospitalID = 1 },
                new HospitalDoctor { HospitalDoctorID = 2, DoctorID = 2, HospitalID = 2 },
                new HospitalDoctor { HospitalDoctorID = 3, DoctorID = 3, HospitalID = 3 },
                new HospitalDoctor { HospitalDoctorID = 4, DoctorID = 4, HospitalID = 4 },
                new HospitalDoctor { HospitalDoctorID = 5, DoctorID = 5, HospitalID = 5 },
                new HospitalDoctor { HospitalDoctorID = 6, DoctorID = 6, HospitalID = 6 });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connString = _config["Data:HospitalConnString"];

            optionsBuilder.UseSqlServer("data source=185.159.152.62;initial catalog=pmwebsit_HospitalDB;user id=pmwebsit_HospitalAdmin;password=s_J8bl87;multipleactiveresultsets=True;application name=EntityFramework&quot;");
        }
    }
}
