using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
	public GameObject[] panels;

	private GameObject activePanel;

	private void Awake()
	{
		activePanel = panels[0];
	}

	private void ChangePanel(GameObject panel)
	{
		activePanel.SetActive (false);
		panel.SetActive (true);
		activePanel = panel;
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
