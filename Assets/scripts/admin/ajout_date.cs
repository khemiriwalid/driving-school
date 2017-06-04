using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ajout_date : MonoBehaviour {
	public Text t;

	public InputField date;
	string CreateUserURL = "localhost/unity/UserDatabase_SetValue_res.php";


	public void delete_user()
	{
		System.Text.RegularExpressions.Regex myRegex = new Regex(@"^([120][0-9]|30|31)/(0[1-9]|10|11|12)/[0-9]*$");
		if (myRegex.IsMatch (date.text)) {
			StartCoroutine ("delete");
			t.text = "";

		} else {
			t.text="Date invalide";
		}
	}


	private IEnumerator delete()
	{
		WWWForm form = new WWWForm();

		form.AddField("date1", date.text);

		WWW itemsData = new WWW(CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		if(itemsData.text.Equals("Success")) t.text="Sucsses d'ajout";
		else if(itemsData.text.Equals("Failed")) t.text="Sucsses d'ajout";
		else if(itemsData.text.Equals("date existe")) t.text="Date existe";
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
