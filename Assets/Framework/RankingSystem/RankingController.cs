using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializedRanking
{
	public RankItem[] items;
}

[Serializable]
public class RankItem
{
	public string name;
	public int points;
}

public class RankingController : MonoBehaviour
{
	public static RankingController Instance;

	private void Awake()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy(gameObject);
		
		DontDestroyOnLoad(gameObject);
	}

	public List<RankItem> items = new List<RankItem>();

	private void Start()
	{
		Load();
	}

	private void Load()
	{
		string data = PlayerPrefs.GetString("RankingData", "");
		if (data == "") return;

		SerializedRanking serializedRanking = JsonUtility.FromJson<SerializedRanking>(data);
		items.Clear();
		items.AddRange(serializedRanking.items);
	}

	private void Save()
	{
		SerializedRanking serializedRanking = new SerializedRanking();
		serializedRanking.items = items.ToArray();
		string data = JsonUtility.ToJson(serializedRanking);
		PlayerPrefs.SetString("RankingData", data);
	}

	public void TestData()
	{
		TryAddItem(new RankItem() {
			name = "Joao",
			points = 9999,
		});
		TryAddItem(new RankItem() {
			name = "Joao",
			points = 9999,
		});
		TryAddItem(new RankItem() {
			name = "Joao",
			points = 9999,
		});
		TryAddItem(new RankItem() {
			name = "Joao",
			points = 9999,
		});
	}

	public bool TryAddItem(RankItem item)
	{
		if (items.Count < 10)
		{
			items.Add(item);
			return true;
		}

		if (items[items.Count - 1].points < item.points)
		{
			items.RemoveAt(items.Count - 1);
			items.Add(item);
			return true;
		}

		return false;
	}
}
