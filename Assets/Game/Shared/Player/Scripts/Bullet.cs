﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class Bullet : MonoBehaviour
	{
		public float speed;
		public float lifetime;
		public Rigidbody2D rb;

		// Use this for initialization
		void Start()
		{
			rb = GetComponent<Rigidbody2D>();
			Destroy(gameObject,lifetime);
		}

		private void FixedUpdate()
		{
			rb.velocity = transform.up * speed;
		}

		// Update is called once per frame
		void Update()
		{

		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
			if (other.collider.CompareTag("Wall") || other.collider.CompareTag("A") || other.collider.CompareTag("B"))
			{
				Destroy(this.gameObject);
			}
		}
	}
}