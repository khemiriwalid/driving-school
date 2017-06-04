using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class test : MonoBehaviour {

	public string[] items;
	public string[] champs;
	public Transform prefab;
	public Transform userlister;


	public void afficher_client()
	{
		StartCoroutine ("afficher");
	}

	IEnumerator afficher(){
		WWWForm form = new WWWForm();

		form.AddField("cin", authentification.cin);
		WWW itemsData = new WWW("http://localhost/unity/ItemsData.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;

		print (itemsDataString);
		items = itemsDataString.Split('\n');
		float height = 100;
		userlister.GetComponent<RectTransform> ().sizeDelta = new Vector2 (450f, height);
		foreach (string s in items) 
		{
			Transform item = Instantiate (prefab, userlister);
			item.GetChild (2).GetComponent<Text> ().text ="walid" ;
			item.GetChild (3).GetComponent<Text> ().text = "khemiri";
			item.gameObject.SetActive (true);
			champs = s.Split(':');
			foreach (string c in champs)
				Debug.Log (c);
		}

		/*print(GetDataValue(items[0], "Cost:"));*/
	}

	/*string GetDataValue(string data, string index){
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;
	}*/


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
