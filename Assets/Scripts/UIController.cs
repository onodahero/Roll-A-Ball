using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

	public static UIController I;
	// Use this for initialization

	public Text GameClearLabel;
	public Text GameOverLabel;

	void Start ()
	{
		GameClearLabel.gameObject.SetActive (false);
		GameOverLabel.gameObject.SetActive (false);
	}

	public void ShowGameClearLabel ()
	{
		GameClearLabel.gameObject.SetActive (true);
	}

	public void ShowGameOverLabel ()
	{
		GameOverLabel.gameObject.SetActive (true);
	}

	public void ClickRetryButton ()
	{
		OnDestroy ();
		SceneManager.LoadScene ("Game");
	}

	public void OnDestroy(){
		I = null;
	}
		
}
