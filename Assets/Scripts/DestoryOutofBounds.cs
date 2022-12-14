using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutofBounds : MonoBehaviour
{
    private float upBound = 30.0f;
    private float lowBound=-10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upBound){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
