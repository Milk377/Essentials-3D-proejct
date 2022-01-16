using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{

    delegate void MyDelegate(int num);
    MyDelegate myDelegate;
    MyDelegate myDelegate2;


    private void Start()
    {
        myDelegate = Skill1;
        myDelegate2 += Skill1;
        myDelegate2 += Skill2;

        myDelegate(50);
        myDelegate2(100);
    }

    void Skill1(int num)
    {
        Debug.Log("attack skill1 " + num);
    }

    void Skill2(int num)
    {
        Debug.Log("attack skill2 " + num);
    }

    
}
