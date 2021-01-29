using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyMover : MonoBehaviour
{
	public GameObject DeffoNotATrap;

	public Rigidbody GuysRigidBody;

	public KeyCode Up, Down, Left, Right;

	public float Speed;

	private float jumpStrength = 10f;

	private float horizontal, Vertical;

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

	private void SIKE()
	{
		Debug.LogWarning("YOU FUCKIG IDIOT, I TRICKED YOU!");
		DeffoNotATrap.SetActive(false);
	}
}
