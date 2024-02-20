using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstOfOccurrence : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnFirstOccurrence()
    {
        int num = 81;
        int[] array = {81, 22, 13, 34, 10, 34, 15, 26, 71, 68};
    
        FirstOccurrence(array, num);

        int num2 = 23;
        FirstOccurrence(array, num2);

            
    }

    private void FirstOccurrence(int[] arr, int number)
{   
    int foundIndex = -1;

    for(int index = 0; index < arr.Length; index++)
    {
        if(number == arr[index])
        {
            foundIndex = index; 
            break;
        }
    }

    Debug.Log($"Число {number} имеет индекс {foundIndex}"); 
}

}
