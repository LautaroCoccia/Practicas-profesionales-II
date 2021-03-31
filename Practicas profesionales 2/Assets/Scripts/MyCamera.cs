using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    [Header("references")]
    public List<GameObject> Planets;

    public float smoothSpeed;
    public Vector3 offset;

    int index = 0;
    int counter = 0;

    Vector3 desiredPosition;
    Vector3 smoothedPosition;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject planet in GameObject.FindGameObjectsWithTag("planets"))
        {
            Planets.Add(planet);
        }
        index = Planets.Count - 1;
        
    }  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (counter < index)
                counter++;
            
            else
                counter = 0 ;

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (counter > 0)
                counter--;
            
            else
                counter = index;
        }

        
    }

    private void LateUpdate()
    {
        desiredPosition = Planets[counter].transform.position + offset;
        smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        
    }
   
}
