using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class RankItemView
{
	public Text name;
	public Text points;
}

public class RankingView : MonoBehaviour
{
    public RankItemView[] itemViews;

    private void OnEnable()
    {
        ClearItems();
        LoadItems();
    }

    private void LoadItems()
    {
        for(int i = 0; i < RankingController.Instance.items.Count; i++)
        {
            itemViews[i].name.text = RankingController.Instance.items[i].name;
            itemViews[i].points.text = RankingController.Instance.items[i].points + "pts";
        }
    }

    private void ClearItems()
    {
        foreach (var itemView in itemViews)
        {
            itemView.name.text = "";
            itemView.points.text = "";
        }
    }
}
