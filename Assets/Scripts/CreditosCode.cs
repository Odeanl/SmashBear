using UnityEngine;
using System.Collections;

public class CreditosCode : MonoBehaviour {

	public float Descendo;
	float Final, Inicial;
	void Start () {
	Final = 31f;
	Inicial = -15f;
	}
	//28 o y
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3(0.0f, Descendo, 0.0f);
		
		if(this.transform.position.y >= Final){
			this.transform.position = new Vector3(1.5f, Inicial, 10f);
		}
		
	
	}
}
