using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsCE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericsGC<int> myClass = new GenericsGC<int>();
        myClass.UpdateItem(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
