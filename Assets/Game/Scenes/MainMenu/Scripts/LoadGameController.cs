using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameController : MonoBehaviour
{
	public void Load()
	{
		SceneManager.LoadScene("Gameplay");
	}
}
