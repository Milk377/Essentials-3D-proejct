using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �� �۵��Ѵ�. ��մ°�? 
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
