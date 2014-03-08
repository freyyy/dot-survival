using UnityEngine;
using System.Collections;

public class DotMove : MonoBehaviour {

	public Camera cam;
	Vector3 camCoord;
	public float speed;
	bool faceright;
	// Use this for initialization
	void Start () 
	{
		faceright = true;
		speed = 5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveRL = Input.GetAxis ("Horizontal");
		float moveUD = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (moveRL * speed, moveUD * speed);
		camCoord = transform.localPosition;
		camCoord.z = -10.0f;
		cam.transform.localPosition = camCoord;

		if((moveRL > 0 && !faceright) || (moveRL < 0 && faceright))
		{
			print ("pula");
			Flip ();
		}

	}

	void Flip()
	{
		faceright = !faceright;
		Vector2 flip = transform.localScale;
		flip.x *= -1;
		transform.localScale = flip;
	}

}
