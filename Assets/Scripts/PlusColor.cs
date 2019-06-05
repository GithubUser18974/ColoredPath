using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusColor : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor")
        {
            this.GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
        }
      
    }
}
