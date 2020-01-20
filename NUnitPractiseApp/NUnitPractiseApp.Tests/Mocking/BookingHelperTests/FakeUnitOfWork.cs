using System;
using System.Linq;
using TestNinja.Mocking;

namespace NUnitPractiseApp.Tests.Mocking
{
    class FakeUnitOfWork : IUnitOfWork
    {
        public IQueryable<T> Query<T>()
        {
            return null;
        }
    }
}
