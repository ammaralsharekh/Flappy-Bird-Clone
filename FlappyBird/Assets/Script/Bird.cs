using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {


	public GameObject Hit;
	public GameObject Die;
	public static int Points=0;
	public static bool IsAlive =true;
	public static bool IsStart=false;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim=gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(!IsStart)
		{
			gameObject.rigidbody2D.Sleep();
			if(Input.GetMouseButtonDown(0))
			{
				IsStart=true;
				gameObject.rigidbody2D.WakeUp();
			}else
			{
				return;
			}
		}
		if(!Bird.IsAlive)
		{
			anim.SetBool("IsAlive",false);
			gameObject.rigidbody2D.velocity =new Vector2(0,gameObject.rigidbody2D.velocity.y);
			gameObject.transform.rotation = new Quaternion(0,0, -1,1);
			return;
		}

		gameObject.transform.rotation = new Quaternion(0,0, gameObject.rigidbody2D.velocity.y/10,1);
		if(Input.GetMouseButtonDown(0)&& gameObject.transform.position.y < 3)
		{
			gameObject.rigidbody2D.velocity =new Vector2(0,3f);
			audio.Play();
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(!IsAlive)
			return;

		IsAlive =false;
		Hit.audio.Play();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(!IsAlive)
			return;
		if(other.tag =="point")
		{
			Points++;
			other.audio.Play();
			return;
		}

		IsAlive =false;
		Die.audio.Play();
		Hit.audio.Play();

	}
}
