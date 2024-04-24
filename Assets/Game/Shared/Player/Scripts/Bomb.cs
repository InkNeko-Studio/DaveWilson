using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class Bomb : MonoBehaviour
	{
		private Animator bombanim;
		public float explosiontime;

		// Use this for initialization
		void Start()
		{
			bombanim = GetComponent<Animator>();
			Invoke("Explode", explosiontime);
		}

		// Update is called once per frame
		void Update()
		{
			
		}
		
		private void Explode()
		{
			bombanim.SetTrigger("Explode");
			Destroy(this.gameObject, explosiontime);
		}
	}
}