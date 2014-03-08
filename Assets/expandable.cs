using UnityEngine;
using System.Collections;

public class expandable : MonoBehaviour {

	public Vector2 size;

	public float sizeRatio;
	public float acceleration;
	public bool maxSzieReached;

	public float maxSizeScale;
	public float minSize;
	public float sizeToReach;
	
	// Use this for initialization
	void Start () {

		//inst = false;
		size = transform.localScale;
		size.x = 0.01f;
		size.y = 0.01f;

		//Acceleration control values.
		sizeRatio = 0f;
		acceleration = 0.0005f;

		//The object hasn't reached his full size.
		maxSzieReached = false;

		//Randomisation of grouth values.
		minSize = 1; //min range
		maxSizeScale = 8; //max range
		//random generated range;
		sizeToReach = (float)(minSize + Random.value * maxSizeScale);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (size.x < sizeToReach && !maxSzieReached)
		{
			size.x += sizeRatio;
			size.y += sizeRatio;

			sizeRatio += acceleration;

			if(size.x >= sizeToReach)
				maxSzieReached = true;
		}
		if (maxSzieReached && maxSzieReached) 
		{
			size.x -= sizeRatio;
			size.y -= sizeRatio;
			
			sizeRatio -= acceleration;
		}
		transform.localScale = size;
	}
}
