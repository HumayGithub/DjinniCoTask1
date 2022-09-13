using DjinniCoTask.EntityFrameworkCore;

namespace DjinniCoTask.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly DjinniCoTaskDbContext _context;

        public TestDataBuilder(DjinniCoTaskDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}