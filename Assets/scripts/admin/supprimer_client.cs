using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class supprimer_client : MonoBehaviour {
	public InputField cin;
	string CreateUserURL = "localhost/unity/UserDatabase_DeleteValue.php";
	public Text t;


	public void delete_user()
	{
		if(cin.text.Equals("") )t.text="Insérer le cin de client";
			else
		StartCoroutine ("delete");
	}


	private IEnumerator delete()
	{
		WWWForm form = new WWWForm();

		form.AddField("cin", cin.text);

		WWW itemsData = new WWW(CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		if (itemsDataString.Equals ("Success"))
			t.text = "Success de supression";
		else if (itemsDataString.Equals ("pas")) t.text = "CIN n'existe pas";
		else if (itemsDataString.Equals ("Failed")) t.text = "Erreur";
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
