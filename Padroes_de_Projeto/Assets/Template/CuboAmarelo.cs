using UnityEngine;
using System.Collections;

public class CuboAmarelo : MonoBehaviour,CorCubo {

	public void atribuirCor(){
		print("Cubo Amarelo");
		GameObject.Find ("CuboTemplate").AddComponent<Renderer> ().material.color = Color.yellow;
	}
}
