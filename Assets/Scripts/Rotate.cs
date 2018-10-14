using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 speed = new Vector3(10f,0f,0f);

	void Update () {
        transform.Rotate(speed * Time.deltaTime);
	}
}
