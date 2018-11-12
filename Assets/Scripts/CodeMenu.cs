using UnityEngine;
using System.Collections;

public class CodeMenu : MonoBehaviour {

	
	void Start () {
	
	}
	
	void Update () {
	
	}
	void OnGUI(){
		if (GUI.Button(new Rect(10, 10, 80,80), "Jogar"))
		{
		   Application.LoadLevel("Jogando");
			
		}
		if(GUI.Button(new Rect(150,10,80,80), "Creditos"))
		{
			Application.LoadLevel("Creditos");
		}
		if(GUI.Button(new Rect(310,10,80,80), "Instrucoes"))
		{
			Application.LoadLevel("Instrucoes");
		}
            
	}
}
