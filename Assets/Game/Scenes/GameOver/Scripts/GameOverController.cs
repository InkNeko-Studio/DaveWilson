using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scenes.GameOver.Scripts
{
	public class GameOverController : MonoBehaviour
	{
		public static GameOverController Instance;

		private void Awake()
		{
			if (Instance == null)
				Instance = this;
			else
				Destroy(gameObject);
			
			DontDestroyOnLoad(gameObject);
		}

		public int points;

		public void EndGame(int pt)
		{
			points = pt;
			SceneManager.LoadScene("GameOver");
		}
	}
}
