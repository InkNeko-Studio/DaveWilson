using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
	private Rigidbody2D rigidbody2d;

	public float jumpForce;

	private void Start()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();

		InputController.Instance.OnJump = () => {
			rigidbody2d.AddForce(new Vector2(0, 1) * jumpForce);
			Debug.Log("Jumped");
		};
	}
}
