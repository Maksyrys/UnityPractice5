using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionOfSort : MonoBehaviour
{
    public void OnSelectionSort()
    {
        int[] array = { 64, 25, 12, 22, 11 };

        Debug.Log("Исходный массив:");
        PrintArray(array);

        SelectionSortArray(array);

        Debug.Log("\nОтсортированный массив:");
        PrintArray(array);

    }

    static void SelectionSortArray(int[] arr)
    {
        int n = arr.Length;

        // Проходим по всем элементам массива, кроме последнего
        for (int i = 0; i < n - 1; i++)
        {
            // Находим индекс минимального элемента в неотсортированной части массива
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Обмен значениями между текущим элементом и минимальным элементом
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Debug.Log(item + " ");
        }
    }
}

