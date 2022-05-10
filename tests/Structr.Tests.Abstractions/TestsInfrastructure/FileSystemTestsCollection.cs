using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Structr.Tests.Abstractions.TestsInfrastructure
{
    [CollectionDefinition("FileSystemTests", DisableParallelization = false)]
    public class FileSystemTestsCollection : ICollectionFixture<FileSystemTestFixture>
    {
    }
}
