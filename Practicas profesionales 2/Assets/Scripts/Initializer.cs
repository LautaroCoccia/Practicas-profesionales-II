using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [Header("references")]
    public List<GameObject> SpaceObj;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (GameObject spaceship in GameObject.FindGameObjectsWithTag("spaceship"))
        {
            SpaceObj.Add(spaceship);
        }
        foreach (GameObject planet in GameObject.FindGameObjectsWithTag("planets"))
        {
            SpaceObj.Add(planet);
        }
    }
}
