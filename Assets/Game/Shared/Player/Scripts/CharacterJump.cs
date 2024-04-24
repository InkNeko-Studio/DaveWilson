using Framework.InputSystem;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class CharacterJump : MonoBehaviour
	{
		private Rigidbody2D _rigidbody2d;

		public float jumpForce;

		private void Start()
		{
			_rigidbody2d = GetComponent<Rigidbody2D>();

			InputController.Instance.OnJump = () => {
				_rigidbody2d.AddForce(new Vector2(0, 1) * jumpForce);
				Debug.Log("Jumped");
			};
		}
	}
}
