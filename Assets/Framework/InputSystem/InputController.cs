using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	public static InputController Instance;

	private void Awake()
	{
		Instance = this;
	}

	public Action<float> OnMove = (float x) => {};
	private float lastMove = 0f;

	public Action OnJump = () => {};

	private void Update()
	{
		float move = 0f;
		if (Input.GetKey (KeyCode.D))
			move += 1f;
		if (Input.GetKey (KeyCode.A))
			move -= 1f;
		if (move != lastMove)
		{
			OnMove (move);
			lastMove = move;
		}

		if (Input.GetKeyDown (KeyCode.Space))
			OnJump ();
	}
}
