using UnityEngine;
using System.Collections;

public class AsteroidRand : MonoBehaviour 
{
    
    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start() 
    {
    	float x = Random.Range(-10.0f, 10.0f);
    	float z = Random.Range(-10.0f, 10.0f);
    	transform.position = new Vector3(x,0,z);
    }   
}