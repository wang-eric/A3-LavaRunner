using UnityEngine;
using System.Collections;

public class ChestController : MonoBehaviour {
	public GameController gameController;
	//private Transform _transform;

	// Use this for initialization
	void Start () {
		//this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider) {
		if(otherCollider.CompareTag("Player")) {
			this.gameController.Score += 1;
			//Destroy (this.transform.gameObject);

			GetComponent<AudioSource>().Play();
			//this.transform.gameObject.GetComponent<Renderer>().enabled = false;
			//gameObject.GetComponent<CircleCollider2D>().enabled = false;
			// Delay 1f for the destroy action to ensure the audio is played
			//Destroy (gameObject,1f);
			Destroy (this.transform.gameObject,1.5f);
		}
	}
}
