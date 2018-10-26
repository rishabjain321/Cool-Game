using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveFloor : MonoBehaviour {
	//public event ObjectInteractEventHandler ControllerTouchInteractableObject;
	public GameObject player;

	public GameObject floor2, floor3, floor4, floor5, floor6, floor7, floor8, floor9, floor10, floor11, floor12, floor13, floor14, floor15, floor16, floor17, floor18, floor19, floor20, floor21;
	public GameObject floor22, floor23, floor24, floor25, floor26, floor27, floor28, floor29, floor30, floor31, floor32, floor33, floor34, floor35, floor36, floor37, floor38, floor39, floor40, floor41;
	public GameObject floor42, floor43, floor44;
	public int rand = 0;
	public int tempNum = 0;

	public bool startMoving = false;

	public float speed = 8;
	public int direction = 1;
	public float timer = 0;

	public Vector3 movement;

	Vector3 lastPosition;

	[SerializeField]
	GameObject floor;

	[SerializeField]
	Transform firstObject;

	float lenZ = 10.0f;

	public GameObject[] floorArray;


	// Use this for initialization
	void Start () {
		floorArray = new GameObject[44];
		floorArray [0] = floor;
		floorArray [1] = floor2;
		floorArray [2] = floor3;
		floorArray [3] = floor4;
		floorArray [4] = floor5;
		floorArray [5] = floor6;
		floorArray [6] = floor7;
		floorArray [7] = floor8;
		floorArray [8] = floor9;
		floorArray [9] = floor10;
		floorArray [10] = floor11;
		floorArray [11] = floor12;
		floorArray [12] = floor13;
		floorArray [13] = floor14;
		floorArray [14] = floor15;
		floorArray [15] = floor16;
		floorArray [16] = floor17;
		floorArray [17] = floor18;
		floorArray [18] = floor19;
		floorArray [19] = floor20;
		floorArray [20] = floor21;
		floorArray [21] = floor22;
		floorArray [22] = floor23;
		floorArray [23] = floor24;
		floorArray [24] = floor25;
		floorArray [25] = floor26;
		floorArray [26] = floor27;
		floorArray [27] = floor28;
		floorArray [28] = floor29;
		floorArray [29] = floor30;
		floorArray [30] = floor31;
		floorArray [31] = floor32;
		floorArray [32] = floor33;
		floorArray [33] = floor34;
		floorArray [34] = floor35;
		floorArray [35] = floor36;
		floorArray [36] = floor37;
		floorArray [37] = floor38;
		floorArray [38] = floor39;
		floorArray [39] = floor40;
		floorArray [40] = floor41;
		floorArray [41] = floor42;
		floorArray [42] = floor43;
		floorArray [43] = floor44;


		lastPosition = firstObject.transform.position;
		Spawning ();
		InvokeRepeating ("Spawning", 0.0f, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 4.9f) {
			movement = Vector3.left * direction * speed * Time.deltaTime; 
			player.transform.Translate (movement); 
		}
		timer += Time.deltaTime;
	}

	private void Spawning(){
		newRandomNumber ();

		Debug.Log ("Render object");
		GameObject _object = Instantiate (floorArray [rand]) as GameObject;
		//GameObject _object = Instantiate (floorArray [4]) as GameObject;
		_object.transform.position = lastPosition + new Vector3 (0f, 0f, lenZ);
		lastPosition = _object.transform.position;
	}

	public void newRandomNumber(){
		System.Random rnd = new System.Random();

		rand = rnd.Next(40);
		//rand = rnd.Next(15);

		Debug.Log (rand);

		if (rand == tempNum) {
			Debug.Log ("Same");
			newRandomNumber ();
		}

		if (tempNum == 1 || tempNum == 14 || tempNum == 15 || tempNum == 16 || tempNum == 17 || tempNum == 18 || tempNum == 19 || tempNum == 20 || tempNum == 21 || tempNum == 22 || tempNum == 23) {
			if (rand == 2 || rand == 24 || rand == 25 || rand == 26 || rand == 27 || rand == 28 || rand == 29 || rand == 30 || rand == 31 || rand == 32 || rand == 33) {
				Debug.Log ("Rand = 2");
				newRandomNumber ();
			}
		}

		if (tempNum == 2 || tempNum == 24 || tempNum == 25 || tempNum == 26 || tempNum == 27 || tempNum == 28 || tempNum == 29 || tempNum == 30 || tempNum == 31 || tempNum == 32 || tempNum == 33) {
			if (rand == 1 || rand == 14 || rand == 15 || rand == 16 || rand == 17 || rand == 18 || rand == 19 || rand == 20 || rand == 21 || rand == 22 || rand == 23 || rand == 3 || rand == 34 || rand == 35 || rand == 36 || rand == 37 || rand == 38 || rand == 39 || rand == 40 || rand == 41 || rand == 42 || rand == 43) {
				Debug.Log ("Rand = 3");
				newRandomNumber ();
			}
		}

		if (tempNum == 3 || tempNum == 34 || tempNum == 35 || tempNum == 36 || tempNum == 37 || tempNum == 38 || tempNum == 39 || tempNum == 40 || tempNum == 41 || tempNum == 42 || tempNum == 43) {
			if (rand == 2 || rand == 24 || rand == 25 || rand == 26 || rand == 27 || rand == 28 || rand == 29 || rand == 30 || rand == 31 || rand == 32 || rand == 33) {
				Debug.Log ("Rand = 4");
				newRandomNumber ();
			}
		}

		if (tempNum != rand) {
			tempNum = rand;
		}
	}
/*	public virtual void OnControllerTouchInteractableObject(ObjectInteractEventArgs e)
	{
		if (ControllerTouchInteractableObject != null)
		{
			Application.LoadLevel (Application.loadedLevel);  
		}
	}
*/
}
