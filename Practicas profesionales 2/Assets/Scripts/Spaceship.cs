using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 0;
    [SerializeField] private float rotationSpeed = 0;
    [SerializeField] private float maxTime;
    [SerializeField] private float minTime= 0.075f;
    TrailRenderer spaceshipTrail;

    private void Start()
    {
        spaceshipTrail = GetComponent<TrailRenderer>();
        maxTime = spaceshipTrail.time;
    }
    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 direct = new Vector3(hor, 0, 0);
        if (ver>0)
        {
            spaceshipTrail.time = maxTime;
            transform.Translate(Vector3.forward * maxSpeed * Time.deltaTime);
        }
        else if(ver < 0)
        {
            spaceshipTrail.time = minTime;
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
