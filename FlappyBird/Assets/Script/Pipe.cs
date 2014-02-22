using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {


	const float Maxy= 1.8f;
	const float Miny= -1.2f;
	float ForwardSpeed=1;
	// Use this for initialization
	void Start () {
		transform.position=new Vector3(transform.position.x,Random.Range(-0.9f,1.6f),0);
	}
	
	// Update is called once per frame
	void Update () {

		if(!Bird.IsAlive || !Bird.IsStart)
		{
			gameObject.rigidbody2D.velocity =Vector2.zero;
			return;
		}

		if(transform.position.x < -3.5f)
		{
			Reset();
		}
		gameObject.rigidbody2D.velocity =new Vector2(-1.2f,0);
		//transform.Translate(new Vector3(-ForwardSpeed* Time.deltaTime,0,0));	

	}
	public void Reset()
	{
		transform.position=new Vector3(2.5f,Random.Range(-0.9f,1.6f),0);
	}
}
