//This is C# - Object Oriented Programming language (OOP)
//C# has specific syntax rules you have to follow
    //ending a line with a ;
    //enclosing condition within ()
    //group statements with {}
    //case sensitive - C and c are not the same

//these are bundles of pre-written code
//keyword "using" tells our script to include a library
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

//this is a class
//a collection of variables and methods (functions)
//a blueprint for behaviours
//classes can inherit variables and methods from each other allowing modular code (*polymorphism*)
// : indicates inheritace
//MonoBehaviour is the base class for all scripts we want to attach to game objects
public class MyScript : MonoBehaviour
{
    //a varibale is a container to store data we can compare, change, and copy
    //we have to declare a variable before we can use it
        //public/private - whether the variable can be seen from another script
        //data type - what kind of data the variable will hold
        //name - what the variable is called
   [SerializeField] private int myInteger;   //integer - a whole number
    public float myFloat;   //float - number with a decimal place
    public string myString; //string - a collection of characters
    public char myChar;     //character - a single character
    public Text scoreText;

    //methods let you manipulate variables
    //you can call methods (run them) from inside other methods
    //in C# you can define methods in any order
    private void Start()
    {
        MyMethod();
    }
    
    public void MyMethod()
    {
        //all three of these add 1 to myInteger
        myInteger++;
        //myInteger = myInteger + 1;
        //myInteger += 1;

        //also valid:
        //myInteger -= 1;
        //myInteger *= 5;
    }


    private void Update()
    {
        scoreText.text = "Score: " + myInteger.ToString();
        //Score: 1
    }

}
