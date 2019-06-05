using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserManger : MonoBehaviour {
    public float speed = 600;

    void Update () {
        transform.Rotate(0, 0, speed * Time.deltaTime);

    }
    
}
