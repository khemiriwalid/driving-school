using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reservation_function : MonoBehaviour {
	public Text t;
	public string heure;
	string CreateUserURL = "localhost/unity/UserDatabase_Updateres.php";


	public void h8_res()

	{
		if (get_reservation_code.h8 == false) {
			heure="8";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h9_res()
	{
		if (get_reservation_code.h9 == false) {
			heure = "9";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h10_res()
	{
		if (get_reservation_code.h10 == false) {
			heure = "10";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}


	public void h11_res()
	{
		if (get_reservation_code.h11 == false) {
			heure = "11";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h12_res()
	{
		
		if (get_reservation_code.h12 == false) {
			heure = "12";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h13_res()
	{
		if (get_reservation_code.h13 == true) {
			heure = "13";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}
	public void h14_res()
	{
		if (get_reservation_code.h14 == false) {
			heure = "14";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h15_res()
	{
		if (get_reservation_code.h15 == false) {
			heure = "15";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}
	public void h16_res()
	{
		if (get_reservation_code.h16 == false) {
			heure = "16";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}

	public void h17_res()
	{
		if (get_reservation_code.h17 == false) {
			heure = "17";
			StartCoroutine ("reserv");
		} else
		{
			t.text="Réservation invalide";
		}
	}


	private IEnumerator reserv()
	{
		WWWForm form = new WWWForm();

		form.AddField("date1", get_reservation_code.date1);
		form.AddField("cin", authentification.cin);
		form.AddField("heure", heure);

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
