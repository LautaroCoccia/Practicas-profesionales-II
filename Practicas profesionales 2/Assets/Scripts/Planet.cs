
using UnityEngine;

public class Planet : MonoBehaviour
{
    public Transform target;
    Vector3 position;

    double sinA;
    double cosA;

    float distance;
    float myDeltaTime;
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        myDeltaTime += Time.deltaTime * speed;

        position = new Vector3(distance * Mathf.Cos(myDeltaTime), transform.position.y, distance * Mathf.Sin(myDeltaTime));

        transform.position = position;

        transform.position += target.position;
        //rota sobre su propio eje
        //transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up);
    }
}
