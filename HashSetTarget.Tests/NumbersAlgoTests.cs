using AutoFixture;

namespace HashSetTarget.Tests;

[TestFixture]
public class NumbersAlgoTests
{
    private INumbersAlgo _numbersAlgo;
    private Fixture _fixture;
    
    
    [SetUp]
    public void SetUp()
    {
        _fixture = new Fixture();
        _numbersAlgo = _fixture.Create<NumbersAlgo>();
    }
    
    [Test]
    public void TestPositiveScenario()
    {
        var arrInputs = Enumerable.Range(1, 9).ToArray();
        var target = 9;
        bool anyTwoSumToTarget = _numbersAlgo.AnyTwoSumToTarget(arrInputs, target);
        Assert.True(anyTwoSumToTarget);
    }
    
    [Test]
    public void TestNegativeScenario()
    {
        var arrInputs = _fixture.Create<int[]>();
        var target = 9;
        bool anyTwoSumToTarget = _numbersAlgo.AnyTwoSumToTarget(arrInputs, target);
        Assert.False(anyTwoSumToTarget);
    }
    
    [Test]
    public void TestEmptyArray()
    {
        var arrInputs = _fixture.CreateMany<int>().ToArray();
        var target = 1;
        bool anyTwoSumToTarget = _numbersAlgo.AnyTwoSumToTarget(arrInputs, target);
        Assert.False(anyTwoSumToTarget);
    }
    
    [Test]
    public void TestSingleNumber()
    {
        var arrInputs = _fixture.CreateMany<int>(1).ToArray();
        var target = 99;
        bool anyTwoSumToTarget = _numbersAlgo.AnyTwoSumToTarget(arrInputs, target);

        Assert.False(anyTwoSumToTarget);
    }
}