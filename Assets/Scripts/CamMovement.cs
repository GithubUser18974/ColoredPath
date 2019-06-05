using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player;
    private Vector3 startPos;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, player.position.y - offset.y, player.position.z - offset.z);

    }
}