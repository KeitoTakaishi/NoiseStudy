using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniform : MonoBehaviour
{
	public Material mat;
	void Start () {
		
	}
	
	
	void Update () {
		mat.SetFloat("_time",Time.realtimeSinceStartup);
	}
}
