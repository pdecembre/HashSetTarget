namespace HashSetTarget;

public interface INumbersAlgo
{
    public bool AnyTwoSumToTarget(int[] inputs, int target);
}

public class NumbersAlgo : INumbersAlgo
{
    public bool AnyTwoSumToTarget(int[] inputs, int target)
    {
        var processed = new HashSet<int>();
        foreach (var inputItem in inputs)
        {
            // any two numbers in **int[] inputs*** that pass the test:
            // a+b=y => y-a=b || y-b=a
            // then return true result,
            // otherwise, add that value to the tracking list of numbers that have been processed
            if (processed.Contains(target - inputItem))
            {
                return true;
            }

            //when the loop first starts, processed would not contain anything,
            //therefore the first value from **int[] inputs**
            //will just be added the tracking list of processed ones 
            processed.Add(inputItem);
            
            //the foreach will run for every items, until all **int[] inputs** are entered into processed
            // so that at each iteration, the current inputItem,
            // will be used to determine if any value in processed pass the test a+b=y => y-a=b || y-b=a
        }

        return false;
    }
}