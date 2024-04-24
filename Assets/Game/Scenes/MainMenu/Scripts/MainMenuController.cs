using UnityEngine;

namespace Game.Scenes.MainMenu.Scripts
{
	public class MainMenuController : MonoBehaviour
	{
		public GameObject[] panels;

		private GameObject _activePanel;

		private void Awake()
		{
			_activePanel = panels[0];
		}

		private void ChangePanel(GameObject panel)
		{
			_activePanel.SetActive (false);
			panel.SetActive (true);
			_activePanel = panel;
		}

		public void Change(int panel)
		{
			ChangePanel (panels[panel]);
		}

		public void Quit()
		{
			Application.Quit ();
		}
	}
}
