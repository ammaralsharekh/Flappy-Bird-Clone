using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	//public bool ShowIngame;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.renderer.enabled=!Bird.IsStart;
	}
}
