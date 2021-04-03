﻿
using UnityEngine;

public class Planet : MonoBehaviour
{
    public float radius;
    public float speed = 1 ;
    public float angle = 50;
    public float rotationangle = 100;

    // Start is called before the first frame update
    void Start()
    {
        radius = transform.position.x;
        
    }
    // Update is called once per frame
    void Update()
    {
        Planetmovement();
    }

    void Planetmovement()
    {
        Vector3 v3 = Vector3.zero;
        angle += speed * Time.deltaTime;
        rotationangle += speed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.position = v3;
        transform.rotation = Quaternion.Euler(0, rotationangle, 0);
    }
}
