using Framework.InputSystem;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class CharacterMove : MonoBehaviour
	{
		private Rigidbody2D _rigidbody2d;

		public float moveSpeed;
		public float moveDirection = 0f;
		private void Start()
		{
			_rigidbody2d = GetComponent<Rigidbody2D>();

			InputController.Instance.OnMove = (float x) => {
				moveDirection = x;
			};
		}

		private void FixedUpdate()
		{
			_rigidbody2d.velocity = new Vector2 (moveDirection * moveSpeed, _rigidbody2d.velocity.y);
		}
	}
}
