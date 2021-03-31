using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float speed = 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 direct = new Vector3(hor, 0, ver);

        transform.position += direct * speed * Time.deltaTime;

    }
}
