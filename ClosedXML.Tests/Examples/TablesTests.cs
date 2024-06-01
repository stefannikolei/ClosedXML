using ClosedXML.Examples.Tables;
using NUnit.Framework;

namespace ClosedXML.Tests.Examples
{
    [TestFixture]
    public class TablesTests
    {
        [Test]
        [Platform("Win")]
        public void InsertingTables()
        {
            TestHelper.RunTestExample<InsertingTables>(@"Tables\InsertingTables.xlsx");
        }

        [Test]
        [Platform("Win")]
        public void ResizingTables()
        {
            TestHelper.RunTestExample<ResizingTables>(@"Tables\ResizingTables.xlsx");
        }

        [Test]
        public void UsingTables()
        {
            TestHelper.RunTestExample<UsingTables>(@"Tables\UsingTables.xlsx");
        }
    }
}
