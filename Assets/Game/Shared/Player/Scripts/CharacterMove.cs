using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	private Rigidbody2D rigidbody2d;

	public float moveSpeed;
	public float moveDirection = 0f;

	private void Start()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();

		InputController.Instance.OnMove = (float x) => {
			moveDirection = x;
		};
	}

	private void FixedUpdate()
	{
		rigidbody2d.velocity = new Vector2 (moveDirection * moveSpeed, rigidbody2d.velocity.y);
	}
}
