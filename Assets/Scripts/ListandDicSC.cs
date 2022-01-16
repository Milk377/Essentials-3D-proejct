using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListandDicSC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();
        
        // add 3 bad guys
        badguys.Add(new BadGuy("choi", 30));
        badguys.Add(new BadGuy("par", 20));
        badguys.Add(new BadGuy("kim", 10));

        // sort bad guys increment
        badguys.Sort();

        Debug.Log(badguys[0].power - badguys[1].power);
        Debug.Log(badguys[0].CompareTo(badguys[1]));

        foreach (BadGuy g in badguys)
        {
            print(g.name + " " + g.power);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
