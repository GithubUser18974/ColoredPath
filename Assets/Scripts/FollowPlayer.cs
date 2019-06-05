using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform center;
    public Transform left;
    public Transform right;
    public Transform player;
    private float xx;
    // Use this for initialization
    private void Start()
    {
        if (this.name == "CenterBorder")
        {
            xx = center.position.x;

        }
        else if (this.name == "LeftBorder")
        {
            xx = left.position.x;
        }
        else if (this.name == "RightBorder")
        {
            xx = right.position.x;
        }
    }
    // Update is called once per frame
    void Update () {

            this.transform.position = new Vector3(xx, player.position.y, player.position.z);

    }
}
