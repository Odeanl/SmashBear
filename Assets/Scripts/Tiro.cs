using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {
	GameObject UrsoBom;
	GameObject UrsoMau;
	public Ray ray;
	
		
	void Awake(){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	}

	void Start () {

	}

	void Update () {
		TiroRay();
	}
	
    void TiroRay() {
		if(Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			if (Physics.Raycast(ray, out hit, 1000)){
				
				
				
				if (hit.collider.tag != "Plano") {
					
					if(hit.collider.tag == "UrsoMau"){
					
						hit.collider.gameObject.transform.position += new Vector3(0.0f, -10.0f, 0.0f);
						InterfaceDoGame.pontos += 50;
						
					}
			
					else if(hit.collider.tag == "UrsoBom"){
					
						hit.collider.gameObject.transform.position += new Vector3(0.0f, -10.0f, 0.0f);
						InterfaceDoGame.vidas--;
						
					
					}
				}
				
			}
		}
    }
	
}
