using UnityEngine;
using System.Collections;

public class btnReset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Bird.Points=0;
		Bird.IsAlive =true;
		Bird.IsStart=false;
		Input.ResetInputAxes();
		Application.LoadLevel(Application.loadedLevel);
	}
}
