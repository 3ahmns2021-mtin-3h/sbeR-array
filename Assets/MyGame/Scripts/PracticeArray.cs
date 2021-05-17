﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArray : MonoBehaviour
{
    public int[] array1 = new int[4];
    public int[] array2 = new int[4] { 21, 22, 23, 24 };
    public int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    public string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed;
    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        Debug.Log("Element von array 1 hat den Wert:" + array1[0]);
        Debug.Log("Element von array 2 hat den Wert:" + array2[0]);
        Debug.Log("Element von array 3 hat den Wert:" + array3[0]);
        Debug.Log("Element von array 4 hat den Wert:" + array4[0]);
        Debug.Log("Name des ersten GameObjects:" + arrayColoredImagesRed[0].name);

        Debug.Log("Element von array 1 hat den Wert:" + array1[array1.Length - 1]);
        Debug.Log("Element von array 2 hat den Wert:" + array2[array2.Length - 1]);
        Debug.Log("Element von array 3 hat den Wert:" + array3[array3.Length - 1]);
        Debug.Log("Element von array 4 hat den Wert:" + array4[array4.Length - 1]);
        Debug.Log("Name des ersten GameObjects:" + arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void PrintElements(string[] stringArrays)
    {
        for (int i = 0; i < array4.Length; i++)
        {
            Debug.Log("Element Nummer: " + i + "hat den Wert:" + array4[i]);
        }
        
    }
}
