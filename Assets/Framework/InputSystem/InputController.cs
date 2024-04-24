using System;
using UnityEngine;

namespace Framework.InputSystem
{
	public class InputController : MonoBehaviour
	{
		public static InputController Instance;

		private void Awake()
		{
			Instance = this;
		}

		public Action<float> OnMove = (float x) => {};
		private float _lastMove = 0f;

		public Action OnJump = () => {};

		private void Update()
		{
			float move = 0f;
			if (Input.GetKey (KeyCode.D))
				move += 1f;
			if (Input.GetKey (KeyCode.A))
				move -= 1f;
			if (Math.Abs(move - _lastMove) > 0.001f)
			{
				OnMove (move);
				_lastMove = move;
			}

			if (Input.GetKeyDown (KeyCode.Space))
				OnJump ();
		}
	}
}
