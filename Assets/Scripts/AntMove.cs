using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{
	public Vector3 direction;
	
	public GameObject Nest;
	
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = Nest.transform.position;		
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f),0);
		//Debug.Log(direction);
		this.transform.position += direction * 20f * Time.deltaTime;
    }
}
