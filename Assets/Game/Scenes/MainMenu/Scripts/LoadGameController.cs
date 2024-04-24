using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scenes.MainMenu.Scripts
{
	public class LoadGameController : MonoBehaviour
	{
		public void Load()
		{
			SceneManager.LoadScene("Gameplay");
		}
	}
}
