using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumOfEvenNumbersInRange : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        int result = SumEvenNumbersInRange(min,max);
        Debug.Log("Сумма: " + result);
    }

    // Update is called once per frame
    private int SumEvenNumbersInRange(int min, int max )
    {
        int sum = 0;
        for(int num = min; num < max; num++)
        {
            if(num%2==0)
            {
                sum += num;
            }
        }
        return sum;
    }
}
