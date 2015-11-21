using UnityEngine;
using System.Collections;

public class LavaController : MonoBehaviour {
	public GameController gameController;
	public GameObject player;
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
			StartCoroutine(InLava());
		}
	}

	
	IEnumerator InLava(){
		if (this.gameController.Life > 0)
			this.gameController.Life -= 1;
		else
			Application.LoadLevel("End_Lose");
		//Destroy (this.transform.gameObject);
		
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		player.transform.position = new Vector3(16.4f,9.14f,22.8f);
		Debug.Log ("in lava");
		//this.transform.gameObject.GetComponent<Renderer>().enabled = false;
		//gameObject.GetComponent<CircleCollider2D>().enabled = false;
		// Delay 1f for the destroy action to ensure the audio is played
		//Destroy (gameObject,1f);
		//Destroy (this.transform.gameObject,1.5f);
	}
}
