﻿//--------------------------------------------------------------
//
//                    Car Parking Template 3.0
//        
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This is main parking system script

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ParkingManager : MonoBehaviour
{

	//---------------------------------------------------------------------------

	//  t2 => Trigger 2 -  t1 => Trigger 1   t3 => Trigger 3  ...

	//  tFront => Trigger Front  -   tBack => Trigger Back
	public bool t1, t2, t3, t0, tFront, tBack;


	//---------------------------------------------------------------------------
	//Menu object when finish parking
	public GameObject FinishMenu;
	 
	// Is parking...  => Menu for count down 3...2...1...  Parked!!!
	public GameObject TimerCountMen;

	//  Controller gameObject for being disabled when parking is done
	public GameObject Controller;

	//  Show this menu when collision detection is more than 3 => Park is failed...   sorry
	public GameObject FailedMenu;

	//---------------------------------------------------------------------------
	//How much score give to player bassed on collision counts before parking?
	public int CollisionScore0 = 3, CollisionScore1 = 2, CollisionScore2 = 1, CollisionScore3 = 0;

	//---------------------------------------------------------------------------
	// This variables for internal usage
	private bool isFinish, FinisheD, Score, canLoadinnn = true;

	// Internal usage
	float endTime;

	//---------------------------------------------------------------------------
	//Timer CountDown Text
	public Text CountDownText;

	//Collistion Count Text
	public Text CollistionCountText;
	public GameObject TaskCompletePanel;
	public GameObject MissionFaildPanel;

	//Finish Score Text
	public Text FinishScoreText;


	//---------------------------------------------------------------------------
	//Collision Count
	[HideInInspector]public int CollisionCount;
	//---------------------------------------------------------------------------

	//Park place renderer for changing color => green or white
	public MeshRenderer ParkRenderer;

	//---------------------------------------------------------------------------
	public GameObject Helper;
	//---------------------------------------------------------------------------


	//This is alarm sound when collid with something
	public AudioSource AlarmSound;


	// Finish star icons
	public GameObject star1,star2,star3;

	// Finish sound effects
	public AudioClip clipSucces, clipLost;

	// AudouSource for play sound clip s
	AudioSource As;

	// Is time limited?
	public bool timeLimit;

	// Activated when yime limiter is on acrive mode
	public GameObject TimeDownMenu;


	// Update : 1.3
	public Text bestTime,currentTime;

	IEnumerator Start ()
	{
		if (timeLimit) 
			TimeDownMenu.SetActive (true);
		else 
			TimeDownMenu.SetActive (false);



		//This is parking timer
		endTime = Time.time + 4;

		// Start count down from 3 to 0
		CountDownText.text = "3"; 


		// Create ausiou source
		As = gameObject.AddComponent<AudioSource>();
		As.spatialBlend = 0;
		As.playOnAwake = false;
		As.loop = false;


		yield return new WaitForSeconds (.03f);
		//	Helper = GameObject.FindGameObjectWithTag ("Player").GetComponent<Cam> ().helpeer;
	}
	
	//---------------------------------------------------------------------------
	void Update ()
	{
		/*if (Input.GetKeyDown (KeyCode.V))
			Debug.Log (" t0 " + t0 + " t1 " + t1 + " t2 " + t2 + " t3 " + t3 + " tFront " + tFront + " tBack    " + tBack);
			*/
		// Is parking finished?
		if (!FinisheD) {// No ,parking isn't finish, check parking state

			if (t0 && t2 && t3 && t1 && tFront && tBack) {// If all of car triggers being entered in parking place
				// Checking when timer is reached 0(from    3)
				StartCoroutine (CheckTimeToFinisheD ());
				// Level is finished
				isFinish = true;
				// Park renderer is now green(Correct location on parking place)
				ParkRenderer.material.color = Color.green;

				if (canLoadinnn) {
					TimerCountMen.SetActive (true);
					CountDownText.gameObject.SetActive (true);
				}

				int timeLeft = (int)(endTime - Time.time); 
				if (timeLeft < 0)
					timeLeft = 0;

				//Timer Info  3...2...1....
				CountDownText.text = timeLeft.ToString ();
			} else {// Car doesn't on correct parking place
				// Stop checking car parking state
				StopCoroutine (CheckTimeToFinisheD ());
				// Car parking doesn't finish
				isFinish = false;
				// Stop Count down timer
				TimerCountMen.SetActive (false);

				endTime = Time.time + 4;
				
				CountDownText.text = "3"; 

				// Car parking place now idle state =>color is now   white
				ParkRenderer.material.color = Color.white;

			}

			if (timeLimit)
				TimeDown ();
		}
	}
	// This is main function to check  parking state after 3 seconds
	IEnumerator CheckTimeToFinisheD ()
	{
		yield return new WaitForSeconds (4f);
		if (isFinish == true) {


			if (!Score) {
				Score = true;
				FinisheD = true;


				if (CollisionCount == 0) {// Score given to player when collision detection is 0
					PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") + CollisionScore0);
					// Show earned score on finish menu
					FinishScoreText.text = "Awarded Coins : "+CollisionScore0.ToString ();
					star3.SetActive (true);

                    TaskCompletePanel.SetActive(true);


                    PlayerPrefs.SetInt ("Star" + PlayerPrefs.GetInt ("LevelID").ToString (), 3);
					As.clip = clipSucces;
					As.Play ();

						if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) == minutes) {
							if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) != seconds) {
								if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) < seconds)
									PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
						{
							if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) < minutes) {
								PlayerPrefs.SetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString (), minutes);
								PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
					PlayerPrefs.SetInt ("LevelXP", PlayerPrefs.GetInt ("LevelXP") + CollisionScore0);
					bestTime.text = ReadBestTime ();
					currentTime.text = ReadCurrentTIme();
					GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody> ().isKinematic = true;
				}
				if (CollisionCount == 1) {
					PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") + CollisionScore1);
				
					FinishScoreText.text = "Awarded Coins : "+CollisionScore1.ToString ();
					star2.SetActive (true);

                    TaskCompletePanel.SetActive(true);

                    PlayerPrefs.SetInt ("Star" + PlayerPrefs.GetInt ("LevelID").ToString (), 2);
					As.clip = clipSucces; 
					As.Play ();

						if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) == minutes) {
							if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) != seconds) {
								if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) < seconds)
									PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
						{
							if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) < minutes) {
								PlayerPrefs.SetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString (), minutes);
								PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
					PlayerPrefs.SetInt ("LevelXP", PlayerPrefs.GetInt ("LevelXP") + CollisionScore1);
					bestTime.text = ReadBestTime ();
					currentTime.text = ReadCurrentTIme();
					GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody> ().isKinematic = true;
				}
				if (CollisionCount == 2) {
					PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") + CollisionScore2);
				
					FinishScoreText.text = "Awarded Coins : "+CollisionScore2.ToString ();
					star1.SetActive (true);

                    TaskCompletePanel.SetActive(true);

                    PlayerPrefs.SetInt ("Star" + PlayerPrefs.GetInt ("LevelID").ToString (), 1);
					As.clip = clipSucces;
					As.Play ();

						if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) == minutes) {
							if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) != seconds) {
								if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) < seconds)
									PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
						{
							if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) < minutes) {
								PlayerPrefs.SetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString (), minutes);
								PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
					PlayerPrefs.SetInt ("LevelXP", PlayerPrefs.GetInt ("LevelXP") + CollisionScore2);
					bestTime.text = ReadBestTime ();
					currentTime.text = ReadCurrentTIme();
					GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody> ().isKinematic = true;
				}

				if (CollisionCount == 3) {
					PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") + CollisionScore3);

                    MissionFaildPanel.SetActive(true);

                    FinishScoreText.text = "Awarded Coins : "+CollisionScore3.ToString ();
					As.clip = clipLost;
					As.Play ();

						if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) == minutes) {
							if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) != seconds) {
								if (PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ()) < seconds)
									PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
						{
							if (PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ()) < minutes) {
								PlayerPrefs.SetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString (), minutes);
								PlayerPrefs.SetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString (), seconds);
							}
						}
					PlayerPrefs.SetInt ("LevelXP", PlayerPrefs.GetInt ("LevelXP") + CollisionScore3);

					bestTime.text = ReadBestTime ();
					currentTime.text = ReadCurrentTIme();
					GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody> ().isKinematic = true;
				}


				PlayerPrefs.SetInt ("TotalPassed", PlayerPrefs.GetInt ("TotalPassed") + 1);

				//---------------------------------------------------------------------------
				// Player passed one level up

				if (PlayerPrefs.GetInt ("LevelID") + 1 == PlayerPrefs.GetInt ("LevelNum")) {
						PlayerPrefs.SetInt ("LevelNum", PlayerPrefs.GetInt ("LevelNum") + 1);
						PlayerPrefs.SetInt ("PassedLevels", PlayerPrefs.GetInt ("PassedLevels") + 1);
					}

				//---------------------------------------------------------------------------
				// Parking is finished totally
				FinishMenu.SetActive (true);

				// Stop timer menu
				TimerCountMen.SetActive (false);

				CountDownText.gameObject.SetActive (false);

				/// Stop car controller
				Controller.SetActive (false);

				//---------------------------------------------------------------------------


			}
		}

	}



	public void TimeFailed()
	{

		As.clip = clipLost;
		As.Play ();

		FailedMenu.SetActive (true);

		PlayerPrefs.SetInt ("TotalFailed", PlayerPrefs.GetInt ("TotalFailed") + 1);

		// Stop timer menu
		TimerCountMen.SetActive (false);

		CountDownText.gameObject.SetActive (false);

		/// Stop car controller
		Controller.SetActive (false);
		GetComponent<ParkingManager> ().enabled = false  ;
		_text.text = "00:00";
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody> ().isKinematic = true;
	}

	public Text _text;

	public float seconds = 59; // Amount of seconds 
	public float minutes = 0; //Amount of minutes Text _text;

	public void TimeDown()
	{

		if (seconds <= 0) {
			seconds = 59;

			if (minutes >= 1) {
				minutes --;
			} else {
				minutes = 0;
				seconds = 0;
				_text.text  = minutes.ToString ("f0") + ":0" + seconds.ToString ("f0");
			}
		} else 
		{
			seconds -= Time.deltaTime;
			string min;
			string sec;

			if (minutes < 10)
				min = "0" + minutes.ToString ();
			else
				min = minutes.ToString ();

			if (seconds < 10)
				sec = "0" +( Mathf.FloorToInt(seconds)).ToString ();
			else
				sec = (Mathf.FloorToInt(seconds)).ToString ();


			_text.text = min + ":"+ sec;
		}


		if (minutes <= 0 && seconds <= 0)
			TimeFailed ();
		
	}


	string ReadBestTime()
	{
		float min = 0, secn = 0 ;

			 min = PlayerPrefs.GetFloat ("Minutes" + PlayerPrefs.GetInt ("LevelID").ToString ());
			 secn = PlayerPrefs.GetFloat ("Seconds" + PlayerPrefs.GetInt ("LevelID").ToString ());

		string minS,secS;

		minS = min.ToString ();
		secS = Mathf.Floor(secn).ToString ();

		if (min < 10)
			minS = "0" + min.ToString ();

		if (secn < 10)
			secS = "0" + Mathf.Floor(secn).ToString ();

		return "Best Time : "+ minS + ":"+secS;

	}

	string ReadCurrentTIme()
	{



		string min;
		string sec;

		if (minutes < 10)
			min = "0" + minutes.ToString ();
		else
			min = minutes.ToString ();

		if (seconds < 10)
			sec = "0" +( Mathf.FloorToInt(seconds)).ToString ();
		else
			sec = (Mathf.FloorToInt(seconds)).ToString ();


		return "CurrentTime : "+min + ":"+ sec;
	}
}
