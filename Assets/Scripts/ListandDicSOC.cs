using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ListandDicSOC : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("kim",10);
        BadGuy bg2 = new BadGuy("park",20);

        badguys.Add("badguy1", bg1);
        badguys.Add("badguy2", bg2);

        foreach(KeyValuePair<string,BadGuy> pair in badguys)
        {
            // using System;
            Debug.Log("Key and value : " + pair.Key + ", " + pair.Value);
            Console.WriteLine($"Key : {0} , Value: {1}", pair.Key, pair.Value);
        }




    }

}
