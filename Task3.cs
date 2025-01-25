using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int x;
    private int howManyHundred;
    private int howManyFifty;
    private int howManyTwenty;
    private int howManyTen;
    private int howManyFive;
    private int howManyOne;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Bill Calculation
        while (x >= 100)
        {
            x -= 100;
            howManyHundred++;
        }
        while (x >= 50)
        {
            x -= 50;
            howManyFifty++;
        }
        while (x >= 20)
        {
            x -= 20;
            howManyTwenty++;
        }
        while (x >= 10)
        {
            x -= 10;
            howManyTen++;
        }
        while (x >= 5)
        {
            x -= 5;
            howManyFive++;
        }
        while (x >= 1)
        {
            x -= 1;
            howManyOne++;
        }

        //Print How Many of Each Bill
        Debug.Log("Hundreds: " + howManyHundred);
        Debug.Log("Fifties: " + howManyFifty);
        Debug.Log("Twenties: " + howManyTwenty);
        Debug.Log("Tens: " + howManyTen);
        Debug.Log("Fives: " + howManyFive);
        Debug.Log("Ones: " + howManyOne);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
