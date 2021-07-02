using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-8)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
