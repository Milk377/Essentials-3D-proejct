using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아주 잘 작동한다. 재밌는걸? 
public class ResetPosition : MonoBehaviour
{
    Vector3 tempPosition;
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            tempPosition = this.transform.position;

            this.transform.ResetTransformation();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1)){

            this.transform.position = tempPosition;
        }
            

        
        
    }
}
