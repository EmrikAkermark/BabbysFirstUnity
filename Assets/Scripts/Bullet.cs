using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float Speed;

	private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
		rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		rb.velocity = transform.right * Speed;
    }

	private void OnCollisionEnter(Collision collision)
	{
		LoserWhoGetsOwned loser = collision.gameObject.GetComponent<LoserWhoGetsOwned>();
		if(loser != null)
		{
			//Let's see what you can do here
		}
	}
}
