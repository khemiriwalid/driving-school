using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour {
	public Transform prefab;
	public Text t;
	public RectTransform content;
	public ScrollRect scroolciew;
	public Transform userlister;



	// Use this for initialization
	void Start () {
		fetechitemformserver ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void updateitem()
	{
		for (int i = 0; i < 100; i++) 
		{
			var instance = GameObject.Instantiate (prefab.gameObject);
			instance.transform.SetParent (content, false);
		}
		
	}
	void fetechitemformserver()
	{
		float height = 100;
		userlister.GetComponent<RectTransform> ().sizeDelta = new Vector2 (450f, height);
		for (int j = 0; j < 20; j++)
		{
			Transform item = Instantiate (prefab, userlister);
			//item.GetChild (0).GetComponent<Text> ().text ="walid" ;
			//item.GetChild (1).GetComponent<Text> ().text = "khemiri";
			item.gameObject.SetActive (true);
		}

	}
}
