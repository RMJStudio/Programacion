using UnityEngine;
using System.Collections;

public class MoverEsfera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public GameObject esfera;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
			this.transform.position=new Vector3(this.transform.position.x-0.1f,this.transform.position.y);
}
}