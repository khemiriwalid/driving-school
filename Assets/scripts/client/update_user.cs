using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class update_user : MonoBehaviour {

	public InputField login;
	public InputField mdp;
	public InputField nom;
	public InputField prenom;
	public InputField mail;
	public InputField adresse;
	public InputField numero;
	string CreateUserURL = "localhost/unity/UserDatabase_UpdateValue.php";
	public Text t;

	public void modifier_client()
	{
		if(login.text.Equals("") || mdp.text.Equals("") || nom.text.Equals("") || prenom.text.Equals("") || mail.text.Equals("") || adresse.text.Equals("") || numero.text.Equals(""))
			t.text="Insérer tous les champs";
		else
		StartCoroutine ("modifier");
	}

	private IEnumerator modifier()
	{
		WWWForm form = new WWWForm();

		form.AddField("login", login.text);
		form.AddField("mdp", mdp.text);
		form.AddField("nom", nom.text);
		form.AddField("prenom", prenom.text);
		form.AddField("cin", authentification.cin);
		form.AddField("numero", numero.text);
		form.AddField("mail", mail.text);
		form.AddField("adresse", adresse.text);

		WWW itemsData = new WWW(CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		print (itemsDataString);
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
