using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoInimigo : MonoBehaviour {

	private GameObject[] players;
	public float velocidade;

	private float distancia1, distancia2;
	private Rigidbody2D corpo;

	// Use this for initialization
	void Start () {
		
		Debug.Log (GameObject.FindGameObjectsWithTag ("Player"));
		corpo = GetComponent<Rigidbody2D> ();

		players = new GameObject[2];
		players [0] = GameObject.Find("Player 1");
		players [1] = GameObject.Find("Player 2");

		velocidade = velocidade * Time.deltaTime;
		
	}
	
	// Update is called once per frame
	void Update () {

	
		distancia1 = Mathf.Sqrt (players [0].GetComponent<Transform> ().position.x * players [0].GetComponent<Transform> ().position.x + players [0].GetComponent<Transform> ().position.y * players [0].GetComponent<Transform> ().position.y );
		distancia2 = Mathf.Sqrt (players [1].GetComponent<Transform> ().position.x * players [1].GetComponent<Transform> ().position.x + players [1].GetComponent<Transform> ().position.y * players [1].GetComponent<Transform> ().position.y );				

		if (distancia1 < distancia2) {
			if (players [0].GetComponent<Transform> ().position.x > transform.position.x)
				corpo.velocity = new Vector2 (velocidade, corpo.velocity.y);
			else
				corpo.velocity = new Vector2 (-velocidade, corpo.velocity.y);

		} else {
			if (players [1].GetComponent<Transform> ().position.x > transform.position.x)
				corpo.velocity = new Vector2 (velocidade, corpo.velocity.y);
			else
				corpo.velocity = new Vector2 (-velocidade, corpo.velocity.y);
			


		}
	
	}
}
