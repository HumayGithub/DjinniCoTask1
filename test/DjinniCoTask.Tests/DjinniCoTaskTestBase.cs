using System;
using System.Threading.Tasks;
using Abp.TestBase;
using DjinniCoTask.EntityFrameworkCore;
using DjinniCoTask.Tests.TestDatas;

namespace DjinniCoTask.Tests
{
    public class DjinniCoTaskTestBase : AbpIntegratedTestBase<DjinniCoTaskTestModule>
    {
        public DjinniCoTaskTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<DjinniCoTaskDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<DjinniCoTaskDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<DjinniCoTaskDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<DjinniCoTaskDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<DjinniCoTaskDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<DjinniCoTaskDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<DjinniCoTaskDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<DjinniCoTaskDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
