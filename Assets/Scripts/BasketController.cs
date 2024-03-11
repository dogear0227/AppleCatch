using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate=60;
    }

    void Update()
    {
    
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                float x=Mathf.RoundToInt(hit.point.x);
                float z=Mathf.RoundToInt(hit.point.z);
                transform.position=new Vector3(x,0,z);
            }

        }
        
    }
}