using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    [Header("references")]
    public List<GameObject> Planets;

    public float maxSmoothSpeed;
    public float minSmoothSpeed;
    public Vector3 offset;

    int index = 0;
    int counter = 0;
    float smoothSpeed = 0;

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

            smoothSpeed = minSmoothSpeed;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (counter > 0)
                counter--;
            
            else

                counter = index;

            smoothSpeed = minSmoothSpeed;
        }

        if (smoothSpeed >= minSmoothSpeed && smoothSpeed <= maxSmoothSpeed)
        {
            Vector3 desiredPosition = Planets[counter].transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;
            smoothSpeed += (Time.deltaTime * 3);
        }
        

    }

    private void LateUpdate()
    {
        if(smoothSpeed>= maxSmoothSpeed)
        {
            transform.position = Planets[counter].transform.position + offset;
        }
    }


}
