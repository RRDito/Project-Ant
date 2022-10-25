using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{
	public Vector3 direction;
	public Vector3 target;
	
	
	public GameObject Nest;
	
		
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate (Vector3.forward * Random.Range(-180.0f, 180.0f));		
    }

    // Update is called once per frame
    void Update()
    {
		target = new Vector3 (transform.up.x, transform.up.y, this.transform.position.z);
		direction = target - this.transform.position;
		//transform.up
		this.transform.position += (direction.normalized*0.5f*Time.deltaTime);
		transform.Rotate (Vector3.forward * Random.Range(-15.0f, 15.0f) * 80f * Time.deltaTime);		
		
    }
}
