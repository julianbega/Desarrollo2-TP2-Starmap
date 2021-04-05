using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    // Start is called before the first frame update

    public class PlanetData
    {
        public float traslationRadius;
        public float traslationSpeed;

        public Vector3 rotationAxis;
        public float rotationSpeed;

        public float size = 1;

        public Material mat;
    }

    public float speed = 5;
    public float radius = 2;
    public float angle = 0;

    public float rotationAngle = 0;

    public Vector3 wantedScale;

    public float rotationSpeed = 5;

    public Vector3 rotationDirection;

    public void Init(PlanetData pd)
    {
        radius = pd.traslationRadius;
        speed = pd.traslationSpeed;
        rotationDirection = pd.rotationAxis;
        rotationSpeed = pd.rotationSpeed;
        wantedScale = Vector3.one * pd.size;
        GetComponent<MeshRenderer>().material = pd.mat;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = Vector3.zero;
        angle += speed * Time.deltaTime;
        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.position = v3;

        transform.localScale = wantedScale;

        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
