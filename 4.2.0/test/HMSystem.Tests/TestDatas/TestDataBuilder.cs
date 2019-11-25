using HMSystem.EntityFrameworkCore;

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
            //create test data here...
        }
    }
}