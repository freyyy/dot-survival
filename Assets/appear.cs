using UnityEngine;
using System.Collections;

public class appear : MonoBehaviour {

	public GameObject obj;
	bool isAlive;
	GameObject clone;
	// Use this for initialization
	void Start () {
		isAlive = true;
		clone = (GameObject) Instantiate (obj);
	}
	
	// Update is called once per frame
	void Update () {
		if (isAlive && clone.transform.localScale.x <= 0)
		{
			print("Muie");
			Destroy (clone);
			isAlive = false;
		}
	}
}
