using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeValidColor : MonoBehaviour {
    [SerializeField]
    private Renderer chrone;
    [SerializeField]
   



    void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.tag == "Player")
        {
            chrone.material.color = this.GetComponent<Renderer>().material.color;
        }
       

    }
 
}
