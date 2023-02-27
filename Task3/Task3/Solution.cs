using System;

class Solution
{
    /*
    * Time complexity:  O(N), since we traverse the input array once and where N is the length of the input array.
    * Space complexity: O(1), since we modify the input array in place. 
    */
    public int solution(int[] A)
    {
        var numberOfCarsGoingEast = 0;
        var numberOfPassingCars = 0;

        foreach (var car in A)
        {
            // If car going east, increment the number of cars going east
            if (car == 0)
            {
                numberOfCarsGoingEast++;
            }
            // If car is going west, add number of cars going east to the number of passing cars
            // If number of passing cars exceeds 1,000,000,000, return -1
            else
            {
                numberOfPassingCars += numberOfCarsGoingEast;
                if (numberOfPassingCars > 1000000000)
                {
                    return -1;
                }
            }
        }
        return numberOfPassingCars;
    }
}

