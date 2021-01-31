using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
	public GameObject Bullet;
	public Transform BulletShootyBit;

	public KeyCode ShootButton;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(ShootButton))
		{
			GameObject newBullet = Instantiate(Bullet);
			newBullet.transform.position = BulletShootyBit.position;
		}
    }
}
