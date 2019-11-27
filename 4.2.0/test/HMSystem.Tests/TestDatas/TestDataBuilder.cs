using HMSystem.EntityFrameworkCore;
using HMSystem;
using static HMSystem.ServicePersonalBase;

namespace HMSystem.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly HMSystemDbContext _context;

        public TestDataBuilder(HMSystemDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Persons.AddRange(
                new ServicePersonalBase() 
                { 
                    ServicePersonalID = 1,
                    ServicePersonalGender =Gender.Man,
                    BirthDay=System.DateTime.Now,
                    Type=ServiceType.Nanny,
                    NumberOfRoles=1
                },
                new ServicePersonalBase() 
                {
                    ServicePersonalID = 2,
                    ServicePersonalGender = Gender.Woman,
                    BirthDay = System.DateTime.Now,
                    Type = ServiceType.Nanny,
                    NumberOfRoles = 2
                }
                );
        }
    }
}