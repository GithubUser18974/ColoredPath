﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHead : MonoBehaviour {

    public Transform player;

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 0.4f);
	}
}
