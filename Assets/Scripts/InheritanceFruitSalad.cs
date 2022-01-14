using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceFruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Let's illustrate inheritance with the 
        //default constructors.
        Debug.Log("Creating the fruit");
        InheritanceFruit myFruit = new InheritanceFruit();
        Debug.Log("Creating the apple");
        InheritanceApple myApple = new InheritanceApple();


        myApple.tellColor();

        //Call the methods of the Apple class.
        //Notice how class Apple has access to all
        //of the public methods of class Fruit.
       
        myApple.Chop();

        //Now let's illustrate inheritance with the 
        //constructors that read in a string.
        Debug.Log("Creating the fruit");
        myFruit = new InheritanceFruit("green");
        myFruit.Chop();
        Debug.Log("Creating the apple");
        myApple = new InheritanceApple("fire");

        //Call the methods of the Fruit class.
        //myFruit.SayHello();

        //Call the methods of the Apple class.
        //Notice how class Apple has access to all
        //of the public methods of class Fruit.
        myApple.tellColor();
    }
}
