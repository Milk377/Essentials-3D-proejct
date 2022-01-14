using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceFruit 
{
    public string color;

    // This is the first constructor for the Fruit class
    // and is not inherited by any derived classes
    public InheritanceFruit()
    {
        // default color = orange.
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    // 이렇게 해도 되지 않나?
    // 생성자에 초기값 넣기.
    public InheritanceFruit(string _color = "yellow")
    {
        // default color = orange.
        color = _color;
        Debug.Log("2st Fruit Constructor Called");
    }


    //This is the second constructor for the Fruit class
    // and is not inherited by any derived classes.

    //overloading
    //public InheritanceFruit(string newColor)
    //{
    //    color = newColor;
    //    Debug.Log("2nd Fruit Constructor with Color parameter");
    //}

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped. ");
    }




}
