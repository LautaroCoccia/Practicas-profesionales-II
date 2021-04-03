using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float maxSpeed = 0;
    public float rotationSpeed = 0;

   
    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 direct = new Vector3(hor, 0, 0);

        //transform.position += direct * speed * Time.deltaTime;
        if(ver>0)
        {
            transform.Translate(Vector3.forward * maxSpeed * Time.deltaTime);
        }
        else if(ver < 0)
        {
            transform.Translate(Vector3.back * maxSpeed * Time.deltaTime);
        }

        if(hor>0)
        {
            transform.Rotate(new Vector3(0, hor * rotationSpeed * Time.deltaTime, 0));
        }
        else if (hor < 0)
        {
            transform.Rotate(new Vector3(0, hor * rotationSpeed * Time.deltaTime, 0));
        }
    }
}
