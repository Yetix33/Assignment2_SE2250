using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class PlayerController : MonoBehaviour {
	// Update is called once per frame
	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText;
	//public Main maincontroller;
	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Count: " + count.ToString ();
		//maincontroller = GetComponent<Main> ();

	}
	void Update () {
		
	}

	void FixedUpdate(){



		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 roll = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (roll*speed);


	}

	void OnTriggerEnter(Collider other){
		print("ok");
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count += 5;
		} else if (other.gameObject.CompareTag ("silver")) {
			other.gameObject.SetActive (false);
			count += 3;
			
		} else {
			other.gameObject.SetActive (false);
			count += 1;
		
		}

		countText.text = "Count: " + count.ToString ();
			



		}
	
	
	}



