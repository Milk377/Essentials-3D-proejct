using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsSOC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericsSC myClass = new GenericsSC();

        myClass.GenericMethod<int>(5);
        myClass.GenericMethod<string>("Hello Generics");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
