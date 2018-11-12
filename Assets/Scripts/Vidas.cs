using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		guiText.text = "Vidas: " + InterfaceDoGame.vidas.ToString ();
	}
}
