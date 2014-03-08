using UnityEngine;
using System.Collections;

public class DotMove : MonoBehaviour {

	Vector3 dot;
	// Use this for initialization
	void Start () 
	{
		dot = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			dot.y += 0.1f;
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			dot.y -= 0.1f;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			dot.x -= 0.1f;
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			dot.x += 0.1f;
		}
		transform.localPosition = dot;
	}
}
