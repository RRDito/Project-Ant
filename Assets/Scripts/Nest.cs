using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour
{
	public GameObject ant;	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		GameObject[] AllTheAnts = GameObject.FindGameObjectsWithTag("Ant");
		if (AllTheAnts.Length < 50)
		{
			GameObject Ant = Instantiate(ant, new Vector3(0,0,10), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
		}       
    }
}
