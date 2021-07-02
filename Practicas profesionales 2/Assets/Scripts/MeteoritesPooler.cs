using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritesPooler : MonoBehaviour
{
    [SerializeField] GameObject meteoritePrefab;
    [SerializeField] float timeToSpawn = 1;
    [SerializeField] float randomPos = 0;
    float actualTime;

    // Update is called once per frame
    void Update()
    {
        if(actualTime<timeToSpawn)
        {
            actualTime += Time.deltaTime;
        }
        else if(actualTime>=timeToSpawn)
        {
            actualTime = 0;
            for(int i= 0;i< 5;i++)
            {
                GameObject obj = Instantiate(meteoritePrefab);
                obj.transform.position = new Vector3(Random.Range(-randomPos, randomPos), Random.Range(8, 14), Random.Range(-randomPos, randomPos));
            }
        }
    }
}
