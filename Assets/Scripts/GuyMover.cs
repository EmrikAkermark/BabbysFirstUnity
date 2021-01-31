using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyMover : MonoBehaviour
{

	//This is a GameObject, it's a Unity thing and basically the most generic way to interact with something in the level
	public GameObject DeffoNotATrap;

	//This is also a Unity thing, the Rigidbody handles fancy physics stuff!
	public Rigidbody GuysRigidBody;

	//Once again, another Unity thing. This let's you select what buttons on yer keyboard to press to activate shit! Ask Emrik about hardcoding.
	public KeyCode Up, Down, Left, Right;

	//This is a float, a float is not a Unity thing, it's a code thing. A float is just a piece of data, specifically a number with
	//a fuck tonne of decimals
	public float Speed;

	//This float is private, this means you can't access it outside of this script. Useful if you don't want people fucking with these numbers
	private float jumpStrength = 10f;

	private float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
		Jump();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(Up))
		{
			SIKE();
		}
		if(Input.GetKey(Down))
		{
			SIKE();
		}
		if(Input.GetKey(Left))
		{
			SIKE();
		}
		if(Input.GetKey(Right))
		{
			SIKE();
		}
    }

	private void Jump()
	{
		GuysRigidBody.AddForce(transform.up * jumpStrength, ForceMode.Impulse);
	}

	private void GoUp()
	{
		GuysRigidBody.AddForce(transform.forward * Speed);
	}

	private void GoDown()
	{

		GuysRigidBody.AddForce(-transform.forward * Speed);
	}

	private void GoLeft()
	{
		GuysRigidBody.AddForce(-transform.right * Speed);
	}

	private void GoRight()
	{
		GuysRigidBody.AddForce(transform.right * Speed);
	}

	//YOU THOUGHT THIS WAS GONNA BE A NICE TUTORIAL?
	private void SIKE()
	{
		Debug.LogWarning("I TRICKED YOU! IDIOT!!!");
		DeffoNotATrap.SetActive(false);
	}
}
