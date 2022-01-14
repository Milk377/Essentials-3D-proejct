using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceApple : InheritanceFruit
{
    //This is the first constructor for the Apple class.
    //It calls the parent constructor immediately, even
    //before it runs.
    public InheritanceApple()
    {
        //Notice how Apple has access to the public variable
        //color, which is a part of the parent Fruit class.
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    //This is the second constructor for the Apple class.
    //It specifies which parent constructor will be called
    //using the "base" keyword.

    // base ����� �θ� Ŭ������ �����ڸ� ȣ���ϴ°��̴�.
    // �̷��� �Ǹ� ����Ʈ���� yellow �÷��� �ǰ���?
    public InheritanceApple(string newColor) : base(newColor)
    {
        //Notice how this constructor doesn't set the color
        //since the base constructor sets the color that
        //is passed as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }

    public void tellColor()
    {
        Debug.Log("Apple color is " + this.color);
    }

}
