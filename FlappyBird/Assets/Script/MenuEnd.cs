using UnityEngine;
using System.Collections;

public class MenuEnd : MonoBehaviour {

	bool IsActive =false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!IsActive && ! Bird.IsAlive)
		{
			gameObject.transform.GetChild(0).gameObject.SetActive(true);
			gameObject.transform.GetChild(1).gameObject.SetActive(true);
		}
	}
}
