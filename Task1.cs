using UnityEngine;
using System;

public class Task1 : MonoBehaviour
{
    //Values entered into the Inspector
    public string className;
    public int numModules;
    public int numReadingMaterials;
    public int numQuizzes;
    public int numAssignments;
    public int newInstructor;
    private double challengeRating;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Percentage Calculation
        double modulesValue = numModules * 0.15;
        double readingValue = numReadingMaterials * 0.3;
        double quizzesValue = numQuizzes * 0.15;
        double assignmentsValue = numAssignments * 0.3;
        double instructorValue = newInstructor * 0.1;

        //Score Calculation
        challengeRating = modulesValue + readingValue + quizzesValue + assignmentsValue + instructorValue;
        //Write Name of Class and Challenge Rating
        Debug.Log("Class Name: " + className);
        Debug.Log("Challenge Rating: " + challengeRating);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
