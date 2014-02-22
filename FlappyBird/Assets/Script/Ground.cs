using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim=gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!Bird.IsAlive)
		{
			anim.SetBool("IsAlive",false);
		}
	}
}
