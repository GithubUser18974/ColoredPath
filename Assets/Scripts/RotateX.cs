using UnityEngine;

public class RotateX : MonoBehaviour {
    public float speed = 600;
	void Update () {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
	}
}
