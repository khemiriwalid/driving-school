using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class panel : MonoBehaviour {

	public string[] items;
	public string[] champs;
	float yOffset = 0f;
	List<string> maps = new List<string>();
	public  void Start () 
	{
		StartCoroutine ("afficher");
	}

	IEnumerator afficher(){
		WWW itemsData = new WWW("http://localhost/unity/ItemsData.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;

		print (itemsDataString);
		items = itemsDataString.Split('\n');
		foreach (string s in items) 
		{

			champs = s.Split(':');
			foreach (string c in champs)
				maps.Add (s);
		}

		/*print(GetDataValue(items[0], "Cost:"));*/
	}

	/*string GetDataValue(string data, string index){
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;
	}*/
	void OnGUI()
	{
		float yOffset = 0f;

		foreach(string i in maps)
		{
			if( GUI.Button (new Rect (25, 25+ yOffset, 150, 30), i) )
			{
				Debug.Log("pressed Item " + i);
			}

			yOffset += 35;
		}

	}


}


























//void Start(){
//	string data = "ID:1|Name:Health Potion|Type:consumables|Cost:50";
//	print(GetDataValue(data, "Cost:"));
//}
//
//void Update(){
//	
//}
//
//string GetDataValue(string data ,string index){
//	string value = data.Substring(data.IndexOf(index)+index.Length);
//	if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
//	return value;
//}
