using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject backgroundObject;
	private PipesManager pipesManager;

	void Start()
	{
		pipesManager = FindObjectOfType<PipesManager> ();
	}

	public void PlayerIsDead()
	{
		pipesManager.StopAllScroll ();
		backgroundObject.BroadcastMessage (GameMessage.StopScroll);
	}
}
