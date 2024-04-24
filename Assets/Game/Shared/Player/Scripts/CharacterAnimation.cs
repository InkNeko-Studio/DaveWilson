using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class CharacterAnimation : MonoBehaviour
	{
		public Animator anim;
		public CharacterMove move;
		public GameObject dave;

		public GameManager gm;
		// Use this for initialization
		void Start()
		{
		
		}

		// Update is called once per frame
		void Update()
		{
			RunDave();
			JumpDave();
		}

		public void RunDave()
		{
			if (Input.GetKeyDown(KeyCode.D))
			{
				anim.SetBool("Run", true);
				dave.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
			}  
			if (Input.GetKeyDown(KeyCode.A))
			{
				dave.transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
				anim.SetBool("Run", true);
			}
			if(Input.GetKeyUp(KeyCode.A))
			{
				anim.SetBool("Run", false);
			} 
			if (Input.GetKeyUp(KeyCode.D))
			{
				anim.SetBool("Run", false);
			}
		}

		private void JumpDave()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				anim.SetTrigger("Jump");
			}
		}

		private void DamageDave()
		{
			gm.playerlife--;
			anim.SetTrigger("Damage");
			move.moveSpeed = 0;
			Physics.IgnoreLayerCollision(8,9, true);
			Invoke("CallRetur",1);
		}

		private void CallRetur()
		{
			Physics.IgnoreLayerCollision(8,9, false);
			move.Returntowalk();
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
			if (other.collider.CompareTag("Bomb") || other.collider.CompareTag("Enemy"))
			{
				DamageDave();
			}
		}
	}
}