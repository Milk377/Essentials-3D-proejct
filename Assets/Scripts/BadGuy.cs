using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// IComparable<in T> 가 아니라, IComparer<in T> 로 안됨.
// System 네임스페이스를 넣어야 되는거임.

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;
    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    public int Compare(BadGuy x, BadGuy y)
    {
        return x.power - y.power;
    }

    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        //Return the difference in power.
        return power - other.power;
    }


}
