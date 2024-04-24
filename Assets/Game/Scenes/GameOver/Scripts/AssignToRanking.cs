using System;
using Framework.RankingSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scenes.GameOver.Scripts
{
    public class AssignToRanking : MonoBehaviour
    {
        public Text pointsText;
        
        public InputField playerNameText;

        private void Start()
        {
            pointsText.text = GameOverController.Instance.points + "pts";
        }

        public void Submit()
        {
            RankingController.Instance.TryAddItem(new RankItem()
            {
                name = playerNameText.text,
                points = GameOverController.Instance.points,
            });
            SceneManager.LoadScene("MainMenu");
        }
    }
}
