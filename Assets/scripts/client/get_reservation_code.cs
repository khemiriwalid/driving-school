using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class get_reservation_code : MonoBehaviour {
	public Image i8r;
	public Image i8v;
	public Image i9r;
	public Image i9v;
	public Image i10r;
	public Image i10v;
	public Image i11r;
	public Image i11v;
	public Image i12r;
	public Image i12v;
	public Image i13r;
	public Image i13v;
	public Image i14r;
	public Image i14v;
	public Image i15r;
	public Image i15v;
	public Image i16r;
	public Image i16v;
	public Image i17r;
	public Image i17v;
	static public string date1;
	static public bool h8;
	static public bool h9;
	static public bool h10;
	static public bool h11;
	static public bool h12;
	static public bool h13;
	static public bool h14;
	static public bool h15;
	static public bool h16;
	static public bool h17;
	public InputField date;
	public Text t;
	string CreateUserURL = "localhost/unity/UserDatabase_getres.php";
	public string[] champs;
	public void delete_user()
	{


		System.Text.RegularExpressions.Regex myRegex = new Regex(@"^([120][0-9]|30|31)/(0[1-9]|10|11|12)/[0-9]*$");
		if (myRegex.IsMatch (date.text)) {
			StartCoroutine ("reservation");
			t.text = "";

		} else {
			t.text="Date invalide";
		}

	}

	private IEnumerator reservation()
	{
		WWWForm form = new WWWForm ();

		form.AddField ("date1", date.text);

		WWW itemsData = new WWW (CreateUserURL, form);
		yield return itemsData;
		string itemsDataString = itemsData.text;
		if (itemsDataString.Equals ("date invalide")) 
		{
			t.text="Date n'est pas encore disponible";
		} else
		{
			date1 = date.text;
			champs = itemsDataString.Split (';');
		int a = 0;
		foreach (string e in champs) {

			if (!e.Equals ("")) {
				if (a == 0) {
					if (e.Equals ("0")) {
						h8 = false;
						i8v.gameObject.SetActive (true);
						i8r.gameObject.SetActive (false);
					} else {
						h8 = true;
						i8r.gameObject.SetActive (true);
						i8v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 1) {
					if (e.Equals ("0")) {
						h9 = false;
						i9v.gameObject.SetActive (true);
						i9r.gameObject.SetActive (false);
					} else {
						h9 = true;
						i9r.gameObject.SetActive (true);
						i9v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 2) {
					if (e.Equals ("0")) {
						h10 = false;
						i10v.gameObject.SetActive (true);
						i10r.gameObject.SetActive (false);
					} else {
						h10 = true;
						i10r.gameObject.SetActive (true);
						i10v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 3) {
					if (e.Equals ("0")) {
						h11 = false;
						i11v.gameObject.SetActive (true);
						i11r.gameObject.SetActive (false);
					} else {
						h11 = true;
						i11r.gameObject.SetActive (true);
						i11v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 4) {
					if (e.Equals ("0")) {
						h12 = false;
						i12v.gameObject.SetActive (true);
						i12r.gameObject.SetActive (false);
					} else {
						h12 = true;
						i12r.gameObject.SetActive (true);
						i12v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 5) {
					if (e.Equals ("0")) {
						h13 = false;
						i13v.gameObject.SetActive (true);
						i13r.gameObject.SetActive (false);
					} else {
						h13 = true;
						i13r.gameObject.SetActive (true);
						i13v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 6) {
					if (e.Equals ("0")) {
						h14 = false;
						i14v.gameObject.SetActive (true);
						i14r.gameObject.SetActive (false);
					} else {
						h14 = true;
						i14r.gameObject.SetActive (true);
						i14v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 7) {
					if (e.Equals ("0")) {
						h15 = false;
						i15v.gameObject.SetActive (true);
						i15r.gameObject.SetActive (false);
					} else {
						h15 = true;
						i15r.gameObject.SetActive (true);
						i15v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 8) {
					if (e.Equals ("0")) {
						h16 = false;
						i16v.gameObject.SetActive (true);
						i16r.gameObject.SetActive (false);
					} else {
						h16 = true;
						i16r.gameObject.SetActive (true);
						i16v.gameObject.SetActive (false);
					}
					a++;
				} else if (a == 9) {
					if (e.Equals ("0")) {
						h17 = false;
						i17v.gameObject.SetActive (true);
						i17r.gameObject.SetActive (false);
					} else {
						h17 = true;
						i17r.gameObject.SetActive (true);
						i17v.gameObject.SetActive (false);
					}
					a++;
				}
				
			}
		}

	}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
