using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class authentification : MonoBehaviour {
	public Text msg;
	public static string cin;
	public InputField login;
	public InputField mdp;
	string CreateUserURL = "localhost/unity/UserDatabase_CheckValue.php";

	public void user_authentification()
	{
		if (login.text.Equals ("") || mdp.text.Equals ("")) {
			msg.text = "Il faut saisir les 2 champs";
		} else {
			

			StartCoroutine ("authen");
		}
	}

	private IEnumerator authen()
	{
		WWWForm form = new WWWForm();

		form.AddField("login", login.text);
		form.AddField("mdp", mdp.text);

		WWW itemsData = new WWW(CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		if (itemsDataString.Equals ("Incorrect"))
			msg.text = "Vérifier votre login et mdp !";
		else {
			cin = login.text;
			if (itemsDataString.Equals ("client"))
				SceneManager.LoadScene (1);
			else
				SceneManager.LoadScene (6);
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
