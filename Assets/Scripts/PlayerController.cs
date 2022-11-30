using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 15.0f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(transform.position.x < -xRange){
        transform.position = new Vector3(-15, transform.position.y, transform.position.z);
    }
    else if(transform.position.x > xRange){
        transform.position = new Vector3(15, transform.position.y, transform.position.z); 
    }
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    if(Input.GetKeyDown(KeyCode.Space)){
    //Release projectile
    Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);    
    }
    
    }
    
}
