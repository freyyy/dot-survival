using UnityEngine;
using System.Collections;

public class appear : MonoBehaviour {

	public GameObject obj;
	bool[] isAlive = new bool[10];
	GameObject[] clone = new GameObject[10];
	// Use this for initialization
	void Start () {
		for(int i=0; i<10; i++)
		{
			if(Random.value < 0.7)
			{
				clone[i] = (GameObject) Instantiate (obj);
				isAlive[i] = true;
			}
			else
			{
				isAlive[i] = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<10 ;i++)
		{
			if(!isAlive[i] && Random.value < 0.7)
			{
				clone[i] = (GameObject) Instantiate(obj);
				isAlive[i] = true;
			}
			if (isAlive[i] && clone[i].transform.localScale.x <= 0.01)
			{
				Destroy (clone[i]);
				isAlive[i] = false;
			}
		}
	}
}
