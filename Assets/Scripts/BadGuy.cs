using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// IComparable<in T> �� �ƴ϶�, IComparer<in T> �� �ȵ�.
// System ���ӽ����̽��� �־�� �Ǵ°���.

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
