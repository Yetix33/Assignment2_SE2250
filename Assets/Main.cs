using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public GameObject PickUp;
	private GameObject itemA;
	private GameObject itemB;
	private GameObject itemC;
	private GameObject itemD;
	private GameObject itemE;
	private GameObject itemF;
	private GameObject itemG;
	private GameObject itemH;
	public Material materialA;
	public Material materialB;
	public Material materialC;
	public Material materialD;
	public Material materialE;
	public Material materialF;
	public Material materialG;
	public Material materialH;

	public Color silver = new Color(128.0f, 128.0f, 128.0f);
	public Color bronze = new Color(205.0f,127.0f,50.0f);

	// Use this for initialization
	void Start () {
		itemA = Instantiate (PickUp);
		itemB = Instantiate (PickUp);
		itemC = Instantiate (PickUp);
		itemD = Instantiate (PickUp);
		itemE = Instantiate (PickUp);
		itemF = Instantiate (PickUp);
		itemG = Instantiate (PickUp);
		itemH = Instantiate (PickUp);
		materialA = itemA.GetComponent<Renderer> ().material;
		materialA.color = silver;
		itemA.tag = "silver";
		materialB = itemB.GetComponent<Renderer> ().material;
		materialB.color = bronze;
		itemB.tag = "bronze";
		materialC = itemC.GetComponent<Renderer> ().material;
		materialC.color = silver;
		itemC.tag = "silver";
		materialD = itemD.GetComponent<Renderer> ().material;
		materialD.color = bronze;
		itemD.tag = "bronze";
		materialE = itemE.GetComponent<Renderer> ().material;
		materialE.color = silver;
		itemE.tag = "silver";
		materialF = itemF.GetComponent<Renderer> ().material;
		materialF.color = bronze;
		itemF.tag = "bronze";
		/*materialG = itemG.GetComponent<Renderer> ().material;
		materialG.color = bronze;
		materialH = itemH.GetComponent<Renderer> ().material;
		materialH.color = bronze;
*/
		itemA.transform.position = new Vector3 (5.5f,0.5f, 5.5f);
		itemB.transform.position = new Vector3 (-5.5f,0.5f, 5.5f);
		itemC.transform.position = new Vector3 (5.5f,0.5f, -5.5f);
		itemD.transform.position = new Vector3 (-5.5f,0.5f, -5.5f);
		itemE.transform.position = new Vector3 (0.0f,0.5f, 5.5f);
		itemF.transform.position = new Vector3 (5.5f,0.5f, 0.0f);
		itemG.transform.position = new Vector3 (0.0f,0.5f, -5.5f);
		itemH.transform.position = new Vector3 (-5.5f,0.5f, 0.0f);




	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
