using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerController : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public float speed;
	public Text countText;
	public Text winText;


	//at first frame of script loading
	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
		winText.text = "";
	}


    //right before doing any physics calculation
    void FixedUpdate()
    {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

		rb.AddForce (movement * speed);
		
    }
		
	//testing the trigger to another object
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag ("coin")) {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}

	}

	void setCountText(){
		countText.text = "Score: " + count.ToString ();
		if (count >= 12) {
			winText.text = "You Win !!!!";
		}
	}

}