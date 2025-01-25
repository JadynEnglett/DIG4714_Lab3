using UnityEngine;
using System;

public class Task2 : MonoBehaviour
{
    public double x;
    public int y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cost Calculation
        double totalCost = (x * 0.6) + (3 + (0.75 * (y - 1)));

        //Profit Calculation
        double totalProfit = x * y;

        //Output
        Debug.Log("Total Cost: " + totalCost);
        Debug.Log("Total Profit: " + totalProfit);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
