using UnityEngine;
using System.Collections;

public class ScriptDoUrso : MonoBehaviour {

	public float PosX, PosZ, Velocidade;
	public static float PosYMax, PosYMin;
	public int DescendoUrso, UrsoBuraco, BomMau;
	int cont, Estado;
	
	void Start () {
		
		if (this.gameObject.tag == "UrsoBom") {
			this.gameObject.renderer.material.color = Color.green;
		}
		else {
			this.gameObject.renderer.material.color = Color.red;
		}
		Velocidade = 0.25f;
		PosYMax = 1.5f;
		PosYMin = -2.0f;
		DescendoUrso = 0;
	}
	void Update () 
	{
		
		if (InterfaceDoGame.ListaBuraco[UrsoBuraco] == false && BomMau == InterfaceDoGame.R2) {
			Estado = 1;
			InterfaceDoGame.R2 = -1;
		}
		switch(Estado)
		{
			case 1 :
			Subindo();
			break;
			case 3 :
			Descendo();
			break;
			case 0 :
			this.transform.position = new Vector3(PosX, PosYMin + 0.1f, PosZ);
			break;
		}
	}
	void Subindo()
	{
		this.transform.Translate(0.0f, 0.0f, Velocidade);
		if (this.transform.position.y >= PosYMax) 
		{
			Estado = 2;
		}
	}
	void Descendo()
	{
		this.transform.Translate(0.0f, 0.0f, -Velocidade);
		if (this.transform.position.y <= PosYMin)
		{
			InterfaceDoGame.ListaBuraco[UrsoBuraco] = true;
			Estado = 0;
		}
	}
	void FixedUpdate(){
		if (Estado == 2) {
		
		cont++;
		if(cont % (int)InterfaceDoGame.TempoDescer == 0){
		cont = 0;
		Estado = 3;
			
		
		}
	}
	}
	
}

	
