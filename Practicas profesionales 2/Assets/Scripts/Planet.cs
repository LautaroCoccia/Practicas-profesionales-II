
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshPlanet;
    [SerializeField] private Transform spaceship;
    [SerializeField] private float radius;
    [SerializeField] private float translationSpeed = 1;
    [SerializeField] private float translationRadius = 50;
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 100,0);
    Material mat;
    Color originalColor;
    Vector3 v3 = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
        mat = meshPlanet.material;
        originalColor = mat.color;
        radius = transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        Planetmovement();
        if(CalculateDistance()< transform.localScale.x)
        {
            mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, 0.5f);
        }
        else
        {
            mat.color = originalColor;
        }
    }

    void Planetmovement()
    {
        rotationAxis += new Vector3(0, rotationSpeed * Time.deltaTime, 0);
        translationRadius += translationSpeed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(translationRadius);
        v3.z = radius * Mathf.Sin(translationRadius);

        transform.position = v3;

        transform.rotation = Quaternion.Euler(rotationAxis);
    }
    float CalculateDistance()
    {
        return Vector3.Distance(transform.position, spaceship.position);
    }
}


