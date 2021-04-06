
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] private float translationSpeed = 1;
    [SerializeField] private float translationRadius = 50;
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 100,0);

    Transform spaceshipObj;
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

        rotationAxis += new Vector3(0, rotationSpeed * Time.deltaTime, 0);
        translationRadius += translationSpeed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(translationRadius);
        v3.z = radius * Mathf.Sin(translationRadius);

        transform.position = v3;

        transform.rotation = Quaternion.Euler(rotationAxis);
    }
}


