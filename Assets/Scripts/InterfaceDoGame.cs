using UnityEngine;
using System.Collections;

public class InterfaceDoGame : MonoBehaviour {

	public static int R2, vidas, pontos;
	public static float TempoDeSubida, Velocidade, TempoDescer;
	public static bool[] ListaBuraco;
	int tempo2, tempo, R, R3;
	
	void Start () {
		vidas = 10;
		pontos = 0;
		TempoDeSubida = 200;
		ListaBuraco = new bool[12];
		for (int i = 0; i < 12; i++) {
			ListaBuraco[i] = true;
		}
		TempoDescer = 100;
	}
	void Update () {
		
		if (vidas <= 0) {
			Application.LoadLevel("GameOver");
			
		}
		if (tempo2 % TempoDeSubida == 0)
		{
			SubindoUrso();
			tempo2 = 0;
			
		}//Balancear isso \/
		if(TempoDeSubida <= 10.0f)
		{
			TempoDeSubida = 10.0f;
			
		}
		if (TempoDescer <= 35.0f) 
		{
			TempoDescer = 35.0f;
			
		}
		
	}
	void FixedUpdate()
	{	
		tempo++;
		tempo2++;
		if (tempo >= 500) {
			TempoDescer -= 15;
			TempoDeSubida -= 15;
			tempo = 0;
			
		}

		
		
	}
	void SubindoUrso()
	{
		R = Random.Range(0,11);
		if(ListaBuraco[R]) 
		{
			R3 = Random.Range(1,100);
			ListaBuraco[R] = false;
			
		}
		while (ListaBuraco[R] == false)
		{
			R = Random.Range(0,11);
			
		}
		if (R3 % 3 == 0) 
		{
			R2 = 0;	
		}
		if (R3 % 3 != 0)
		{
			R2 = 1;
		}
			
		
	}
	
}
