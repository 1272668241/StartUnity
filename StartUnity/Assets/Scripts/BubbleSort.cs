using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ð������
/// </summary>
public class BubbleSort : MonoBehaviour
{
    
    public void bubbleSort(int [] bubble)
    {
        for (int i = 0; i < bubble.Length - 1; i++)
        {
            for (int j = 0; j < bubble.Length - 1 - i; j++)
            {
                if (bubble[j] < bubble[j + 1])  //����   (bubble[j] > bubble[j + 1] ����)
                {
                    int temp = bubble[j];
                    bubble[j] = bubble[j + 1];
                    bubble[j + 1] = temp;
                }
            }
        }
    }
}
