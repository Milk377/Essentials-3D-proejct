using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이걸 잘 활용하면 무언가의 초기화 등에 잘 이용할 수 있을듯?

public static class ExtensionMethods 
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}
