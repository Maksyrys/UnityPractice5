using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnSumOfEvenNumbers()
    {
        int[] array = {81, 22, 13, 54, 10, 34, 15, 26, 71, 68};
        int result = SumEvenNumbersInArray(array);
        Debug.Log("Сумма чётных чисел массива: "+ result);
    }

    private int SumEvenNumbersInArray(int[] arr)
    {
        int sum = 0;
        foreach(int num in arr)
        {
            if(num %2 == 0)
            {
                sum += num;
            }
        }

        return sum;
    }
}
