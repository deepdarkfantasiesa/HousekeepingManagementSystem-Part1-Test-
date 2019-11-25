using System;
using System.Threading.Tasks;
using Abp.TestBase;
using HMSystem.EntityFrameworkCore;
using HMSystem.Tests.TestDatas;

namespace HMSystem.Tests
{
    public class HMSystemTestBase : AbpIntegratedTestBase<HMSystemTestModule>
    {
        public HMSystemTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<HMSystemDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<HMSystemDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<HMSystemDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<HMSystemDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<HMSystemDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<HMSystemDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<HMSystemDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<HMSystemDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
