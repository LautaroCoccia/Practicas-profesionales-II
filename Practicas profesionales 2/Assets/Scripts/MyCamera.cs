using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    [Header("references")]
    public List<GameObject> SpaceObj;

    public float maxSmoothSpeed;
    public float minSmoothSpeed;
    public Vector3 offset;

    int objSelector = 0;
    int index = 0;
    float smoothSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject spaceship in GameObject.FindGameObjectsWithTag("spaceship"))
        {
            SpaceObj.Add(spaceship);
        }
        foreach (GameObject planet in GameObject.FindGameObjectsWithTag("planets"))
        {
            SpaceObj.Add(planet);
        }
        index = SpaceObj.Count - 1;

        //start offset on camera
        objSelector = 0;
        smoothSpeed = 1;
        OffsetSetter();
        transform.position = SpaceObj[objSelector].transform.position + offset;
    }  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            objSelector = 0;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            objSelector = 1;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            objSelector = 2;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            objSelector = 3;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            objSelector = 4;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            objSelector = 5;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            objSelector = 6;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            objSelector = 7;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            objSelector = 8;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            objSelector = 9;
            ResetSmoothSpeed();
            Debug.Log("Num " + objSelector);
        }

        OffsetSetter();
 
        if (smoothSpeed >= minSmoothSpeed && smoothSpeed <= maxSmoothSpeed)
        {
            Vector3 desiredPosition = SpaceObj[objSelector].transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;
            smoothSpeed += (Time.deltaTime * 3);
        }


    }

    private void LateUpdate()
    {
        if(smoothSpeed>= maxSmoothSpeed)
        {
            transform.position = SpaceObj[objSelector].transform.position + offset;
        }
    }

    void ResetSmoothSpeed()
    {
        smoothSpeed = minSmoothSpeed;
    }
    void OffsetSetter()
    {
        if(SpaceObj[objSelector].tag == "planets")
        {
            offset = new Vector3(0, SpaceObj[objSelector].transform.localScale.y + 2, 0);
        }
        else if(SpaceObj[objSelector].tag == "spaceship")
        {
            offset = new Vector3(0, SpaceObj[objSelector].transform.localScale.y + 10, 0);
        }

    }
}
