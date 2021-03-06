using NUnit.Framework;

namespace Raygun.Druid4Net.Tests.Fluent.Aggregations
{
  [TestFixture]
  public class DoubleSumAggregatorTests : AggregatorTestsBase
  {
    protected override BaseAggregator GetAggregator(string name, string fieldName)
    {
      return new DoubleSumAggregator(name, fieldName);
    }

    protected override string ExpectedAggregatorType => "doubleSum";
  }
}