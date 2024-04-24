using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSize : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("Player"))
		{
			GameManager.Instance.playerboms++;
			Destroy(this.gameObject);
		}
	}
}
