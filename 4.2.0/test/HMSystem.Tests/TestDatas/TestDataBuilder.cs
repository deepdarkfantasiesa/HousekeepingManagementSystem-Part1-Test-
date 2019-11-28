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
            var neo = new Person("Neo");
            _context.People.Add(neo);
            _context.SaveChanges();

            _context.Tasks.AddRange(
            new ServicePersonalBase("Follow the white rabbit", "Follow the white rabbit in order to know the reality.", neo.Id),
            new ServicePersonalBase("Clean your room") { State = TaskState.Completed }
            );
        }
    }
}