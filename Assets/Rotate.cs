using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 0) * Time.deltaTime);
	}
}
