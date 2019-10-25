using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Este es un ejemplo de texto <b> con negrita </b>");
		Debug.Log ("Este es un ejemplo de texto <b><i> con negrita y cursiva</i></b>");
		Debug.Log ("Este es un ejemplo de texto <i><color=red>con cursiva y en rojo</color></i>");
		Debug.Log ("Este es un ejemplo de texto <b>con negrita y <color=red>en rojo</color></b>");
		Debug.Log ("Este es un ejemplo de texto <color=green><size=20> verde y a 20 pixeles</size></color>");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
