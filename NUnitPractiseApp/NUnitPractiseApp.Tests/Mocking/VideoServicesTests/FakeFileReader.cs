using System;
using NUnitPractiseApp.Mocking;

namespace NUnitPractiseApp.Tests.VideoServicesTests
{
    class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
