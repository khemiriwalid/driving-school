using UnityEngine;
using System.Collections;

public class insert : MonoBehaviour {

	public string cin;
	public string login;
	public string mdp;

	string CreateUserURL = "localhost/unity/InsertUser.php";

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) CreateUser(cin, login, mdp);
	}

	public void CreateUser(string username, string password, string email){
		WWWForm form = new WWWForm();
		form.AddField("cin", username);
		form.AddField("login", password);
		form.AddField("mdp", email);

		WWW www = new WWW(CreateUserURL, form);
	}
}
