using UnityEngine;
using System.Collections;

public class appear : MonoBehaviour {

	public GameObject obj;
	public float size;
	bool[] isAlive = new bool[10];
	GameObject[] clone = new GameObject[10];
	Vector2[] rand = new Vector2[10];
	// Use this for initialization
	void Start () {
		size = 19.5f;
		for(int i=0; i<10; i++)
		{
			if(Random.value < 0.5)
			{
				clone[i] = (GameObject) Instantiate (obj);
				isAlive[i] = true;
				rand[i].x = Random.Range(-size,size);
				rand[i].y = Random.Range(-size,size);
			}
			else
			{
				isAlive[i] = false;
			}
		}
		clone[0] = (GameObject) Instantiate (obj);
		isAlive[0] = true;
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<10 ;i++)
		{
			if(!isAlive[i] && Random.value < 0.3)
			{
				clone[i] = (GameObject) Instantiate(obj);
				isAlive[i] = true;
				rand[i].x = Random.Range(-size,size);
				rand[i].y = Random.Range(-size,size);
			}
			if (isAlive[i] && clone[i].transform.localScale.x <= 0)
			{
				Destroy (clone[i]);
				isAlive[i] = false;
			}
			if(isAlive[i])
			{
				clone[i].transform.localPosition = rand[i];
			}
		}
	}
}
