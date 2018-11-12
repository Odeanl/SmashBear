using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	
	
	void Start () {
	
	}
	
	
	void Update () {
	
	}
	void OnGUI(){
		
		if(GUI.Button(new Rect(10,10,80,80), "Voltar"))
		{
			Application.LoadLevel("Menu");
			
		}
	}
}
