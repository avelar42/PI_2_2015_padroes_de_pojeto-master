using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public CorCubo corCubo;

	void Start () {
		print("Template Method");
		corCubo = new CuboVerde ();
		corCubo.atribuirCor ();


		//corCubo.atribuirCor (CuboVerde);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			corCubo = GetComponent<CuboAmarelo>();
		}

	}
}
