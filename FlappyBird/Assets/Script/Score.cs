using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	GUIText txt;
	// Use this for initialization
	void Start () {
		txt=gameObject.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!Bird.IsStart)
			return;
		txt.text =Bird.Points.ToString();
	}
}
