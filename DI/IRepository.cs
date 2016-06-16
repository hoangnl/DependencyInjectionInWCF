using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wcf_ninject.DI
{
    public interface IRepository
    {
        int GetCategory();
    }

    public class RealRepository : IRepository
    {
        public int GetCategory()
        {
            return 1;
        }
    }

    public class MockRepository : IRepository
    {
        public int GetCategory()
        {
            return 10;
        }
    }

    public class FakeRepository : IRepository
    {
        public int GetCategory()
        {
            return 100;
        }
    }
}
