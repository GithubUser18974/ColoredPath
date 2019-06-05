using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed = 300;

    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));

    }
}
