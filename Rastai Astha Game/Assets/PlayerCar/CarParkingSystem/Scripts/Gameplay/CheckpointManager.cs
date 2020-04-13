//--------------------------------------------------------------
//
//                    Car Parking Template 3.0
//        
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class CheckpointManager : MonoBehaviour {


	public int currentCheckpoint;

	public GameObject[] checkpoints;

	// Vehicle GPS (used flash lights to find target)  
	FlashLight fLight;

	IEnumerator Start () {



		for (int a = 0; a < checkpoints.Length; a++) {

			checkpoints [a].SetActive (false);
		}

		checkpoints [0].SetActive (true);

		// Wait a frame to vehicle had spawned
		yield return new WaitForEndOfFrame ();



		fLight = GameObject.FindGameObjectWithTag ("Player").GetComponent<FlashLight> ();

		fLight.SetTarget (checkpoints [currentCheckpoint].transform);

		fLight.isActive = true;



	}

	public void NextCheckpoint()
	{

		currentCheckpoint++;

		for (int a = 0; a < checkpoints.Length; a++) {

			checkpoints [a].SetActive (false);
		}

		if(checkpoints.Length  >   currentCheckpoint)
			checkpoints [currentCheckpoint].SetActive (true);

		fLight.SetTarget (checkpoints [currentCheckpoint].transform);

	}
}
