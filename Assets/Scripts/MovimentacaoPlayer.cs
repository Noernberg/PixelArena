using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour {

	public KeyCode BotaoParaCima, BotaoParaBaixo, BotaoParaDireita, BotaoParaEsquerda;
	public float velocidade = 300, forcaPulo = 300;

	private Rigidbody2D corpo;
	// Use this for initialization
	void Start () {

		corpo = GetComponent<Rigidbody2D> ();
		Debug.Log (KeyCode.UpArrow);
		Debug.Log (KeyCode.DownArrow);
		Debug.Log (KeyCode.LeftArrow);
		Debug.Log (KeyCode.RightArrow);
		
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKeyDown (BotaoParaBaixo))

		if (Input.GetKey (BotaoParaDireita))
			corpo.velocity = new Vector2 (velocidade * Time.deltaTime, corpo.velocity.y); 

		if (Input.GetKey (BotaoParaEsquerda))
			corpo.velocity = new Vector2 (-velocidade * Time.deltaTime, corpo.velocity.y); 

		if (Input.GetKeyDown (BotaoParaCima))
			corpo.AddForce (new Vector2 (0, forcaPulo * Time.deltaTime * 100));
		

			
			
		
	}
}
