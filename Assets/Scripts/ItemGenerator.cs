using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span=1.0f;
    float delta=0;
    int ratio=2;

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta=0;
            GameObject item;
            int dice=Random.Range(1,11);
            if(dice<=this.ratio)
            {
                item=Instantiate(bombPrefab);
            }
            else
            {
                item=Instantiate(applePrefab);
            }
            float x=Random.Range(-1,2);
            float z=Random.Range(-1,2);
            item.transform.position=new Vector3(x,4,z);
        }
        
    }
}
