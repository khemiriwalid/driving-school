using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class genetalfunction : MonoBehaviour {
	
	public void deconnecter(){
		authentification.cin = "";
		SceneManager.LoadScene (0);
	}

	public void reservation_code()
	{
		SceneManager.LoadScene (2);
	}

	public void reservation_conduit()
	{
		SceneManager.LoadScene (3);
	}
	public void modifier_profil()
	{
		SceneManager.LoadScene (4);
	}
	public void details_profil()
	{
		SceneManager.LoadScene (5);
	}

	public void back()
	{
		SceneManager.LoadScene (1);
	}

	public void ajout_utli()
	{
		SceneManager.LoadScene (9);
	}

	public void sup_utli()
	{
		SceneManager.LoadScene (8);
	}
	public void ajout_horiare()
	{
		SceneManager.LoadScene (7);
	}
	public void reserv()
	{
		SceneManager.LoadScene (5);
	}
	public void back_admin()
	{
		SceneManager.LoadScene (6);
	}
}


