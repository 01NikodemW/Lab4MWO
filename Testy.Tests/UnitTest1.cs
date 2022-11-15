namespace Testy.Tests;

public class UnitTest1
{
[Fact]
    public void AppendTwoNumbers()
    {
        //arrange
        Operations calculator = new Operations();
        int firstNumber = 1;
        int secondNumber = 2;

        //act
        int result = calculator.add(firstNumber,secondNumber);

        //assert
        Assert.Equal(3,result);

    }


    [Theory]
    [InlineData(false, 1,2)]
    [InlineData(false, 1,1)]
    [InlineData(true, 3,2)]

    public void Determinenegative(bool properResult, int firstArgument, int secondArgument)
    {
        //arrange
        Operations calculator = new Operations();

        //act
        bool result =  calculator.isFirstNumberGreaterThanSecond(firstArgument,secondArgument);

        //assert
        Assert.Equal(properResult,result);
    }




    [Theory]
    [InlineData(1,0)]
    public void CatchDividingByZero( int firstArgument, int secondArgument)
    {
        //arrange
        Operations calculator = new Operations();

        //act
        Action action  = () =>  calculator.divide(firstArgument,secondArgument);

        //assert
        Assert.Throws<DivideByZeroException>(action);

    }
}