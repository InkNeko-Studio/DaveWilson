using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	// Use this for initialization
	public GameObject bullet;
	public Transform firepoint;
	public float firerate;
	public bool bulletcd;
	void Start ()
	{
		bulletcd = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0) && bulletcd)
		{
			Shoot();
			
		}
	}

	private void Shoot()
	{
		Instantiate(bullet, firepoint.position, firepoint.rotation);
		bulletcd = false;
		Invoke("Guncd",firerate);
	}

	private void Guncd()
	{
		bulletcd = true;
	}
}
