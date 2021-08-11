using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    public float xForce=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(xForce, 0, 0), ForceMode.Impulse);
	
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0,-0.1f,0);
        print("2");

    }

    // will be called once the gameobject hits something with a collider
    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= 1.05f;
    }
   
}
