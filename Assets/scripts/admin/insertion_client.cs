using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class insertion_client : MonoBehaviour {
	public InputField login;
	public InputField mdp;
	public InputField nom;
	public InputField prenom;
	public InputField mail;
	public InputField adresse;
	public InputField numero;
	public InputField cin;
	string CreateUserURL = "localhost/unity/UserDatabase_SetValue.php";
	public Text t;

	public void ajouter_client()
	{
		if(login.text.Equals("") || mdp.text.Equals("") || nom.text.Equals("") || prenom.text.Equals("") || mail.text.Equals("") || adresse.text.Equals("")|| numero.text.Equals("") || cin.text.Equals(""))
			t.text="Insérer tous les champs";
		else
		StartCoroutine ("ajouter");

	}

	private IEnumerator ajouter()
	{
		WWWForm form = new WWWForm();

		form.AddField("login", login.text);
		form.AddField("mdp", mdp.text);
		form.AddField("nom", nom.text);
		form.AddField("prenom", prenom.text);
		form.AddField("cin", cin.text);
		form.AddField("numero", numero.text);
		form.AddField("mail", mail.text);
		form.AddField("adresse", adresse.text);

		WWW itemsData = new WWW(CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		if (itemsDataString.Equals ("Success"))
			t.text = "Success";
		else if (itemsDataString.Equals ("Failed")) t.text="Failed";
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
