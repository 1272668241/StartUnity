using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void insertSort(int [] insert)
    {
        for (int i = 1; i < insert.Length; i++)
        {
            int temp = insert[i];
            int j = i - 1;

            while (j >=0 && insert[j] > temp)
            {
                insert[j + 1] = insert[j];
                j = j - 1;
            }
            insert[j + 1] = temp;
        }
    }
}
