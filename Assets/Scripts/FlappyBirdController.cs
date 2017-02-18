using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdController : MonoBehaviour {

	[Header("Velocity")]
	public float flappyVelocity;

	private Animator animator;

	// Use this for initialization
	void Start () {
		// Convertendo de coordenadas de Tela para Mundo
		Vector3 startPos = 
			Camera.main.ViewportToWorldPoint (new Vector3 (0.2f, 0.8f));

		startPos.z = -1.58f; // Para garantir visibilidade do FlappyBird

		transform.position = startPos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
