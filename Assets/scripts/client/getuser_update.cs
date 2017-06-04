using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getuser_update : MonoBehaviour {
	public InputField adresse;
	public InputField nom;
	public InputField prenom;
	public InputField login;
	public InputField numero;
	public InputField mail;
	public InputField mdp;

	public string[] champs;
	// Use this for initialization
	void Start () {
		Debug.Log ("nnn");
		StartCoroutine ("getuser");
	}

	IEnumerator getuser()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("cin", authentification.cin);
		WWW itemsData = new WWW("http://localhost/unity/ItemsData_update.php",form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		champs = itemsDataString.Split(':');
		login.text = champs [0];
		mdp.text = champs [1];
		nom.text = champs [2];
		prenom.text = champs [3];
		numero.text = champs [4];
		adresse.text = champs [5];
		mail.text = champs [6];

	}
	// Update is called once per frame
	void Update () {
		
	}
}
