using UnityEngine;
using System.Collections;

public class Pontos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		guiText.text = "Pontos: " + InterfaceDoGame.pontos.ToString();
	}
}
