using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    // Static variables are shared across all instances-
    // of a class

    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
    
}
