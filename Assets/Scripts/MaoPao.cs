using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPao : MonoBehaviour
{
    int[] arr = {3,2,1,4,5,6,9,8,7 };
    int[] arr2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = 0; j < arr.Length-i-1; j++)
            {
                int temp;
                if (arr[j]>arr[j+1])
                {
                    temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (var item in arr)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
