using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public List<Transform> Planetas;
    public GameObject Sun;
    private int actualPlanetInSight;
    private Vector3 NewCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        actualPlanetInSight = 0;
        NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
        NewCameraPosition.y += 10;
        this.transform.position = NewCameraPosition;
        Planetas[0] = Sun.transform;
        Planetas[1] = GameObject.Find("Earth(Clone)").transform;
        Planetas[2] = GameObject.Find("Neptune(Clone)").transform;
        Planetas[3] = GameObject.Find("Uranus(Clone)").transform;
        Planetas[4] = GameObject.Find("Mars(Clone)").transform;
        Planetas[5] = GameObject.Find("Mercury(Clone)").transform;
        Planetas[6] = GameObject.Find("Venus(Clone)").transform;
        Planetas[7] = GameObject.Find("Saturn(Clone)").transform;
        Planetas[8] = GameObject.Find("Jupiter(Clone)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (actualPlanetInSight == 8)
            {
                actualPlanetInSight = 0;
            }
            else
            {
                actualPlanetInSight += 1;
            }
            
            NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
            NewCameraPosition.y += 10;
            this.transform.position = NewCameraPosition;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
          
            if (actualPlanetInSight == 0)
            {
                actualPlanetInSight = 8;
            }
            else 
            {
                actualPlanetInSight -= 1;
            }
            NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
            NewCameraPosition.y += 10;
            this.transform.position = NewCameraPosition;
            
        }
        switch (actualPlanetInSight)
        {
            case 1:
                Planetas[1] = GameObject.Find("Earth(Clone)").transform;
                break;
            case 2:
                Planetas[2] = GameObject.Find("Neptune(Clone)").transform;
                break;
            case 3:
                Planetas[3] = GameObject.Find("Uranus(Clone)").transform;
                break;
            case 4:
                Planetas[4] = GameObject.Find("Mars(Clone)").transform;
                break;
            case 5:
                Planetas[5] = GameObject.Find("Mercury(Clone)").transform;
                break;
            case 6:
                Planetas[6] = GameObject.Find("Venus(Clone)").transform;
                break;
            case 7:
                Planetas[7] = GameObject.Find("Saturn(Clone)").transform;
                break;
            case 8:
                Planetas[8] = GameObject.Find("Jupiter(Clone)").transform;
                break;
            default:
                break;
        }
    }
}
