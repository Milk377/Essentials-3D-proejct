using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ForMethod myClass = new ForMethod();
        Debug.Log(myClass.Add(1, 2));
        Debug.Log(myClass.Add("Hello", "Milk!"));

    }


}
