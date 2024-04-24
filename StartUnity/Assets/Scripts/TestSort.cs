using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSort : MonoBehaviour
{
    BubbleSort bubbleSort;
    InsertSort insertSort;
    int[] bubble = { 1, 4, 8, 5, 0, 2 };
    // Start is called before the first frame update
    void Start()
    {
        bubbleSort = new BubbleSort();
        insertSort = new InsertSort();
        foreach (var item in bubble)
        {
            Debug.Log(" " + item + " ");
        }


        //bubbleSort.bubbleSort(bubble);
        insertSort.insertSort(bubble);
        Debug.Log("---------------------------------------------------------------");

        foreach (var item in bubble)
        {
            Debug.Log(" " + item + " ");
        }
    }


    string tt = " ";

    // Update is called once per frame
    void Update()
    {
        List<InsertSort> ins = new List<InsertSort>();
        for (int i = 0; i < 100; i++)
        {
            tt = tt + i;
           // ins.Add(new InsertSort());
        }
    }
}
