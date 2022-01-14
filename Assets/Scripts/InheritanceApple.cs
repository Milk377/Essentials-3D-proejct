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

    // base 사용은 부모 클래스의 생성자를 호출하는것이다.
    // 이렇게 되면 디폴트값인 yellow 컬러가 되겠지?
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
