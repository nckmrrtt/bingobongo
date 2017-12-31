using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public int maxPlatforms = 20;
    public GameObject platform;

    private Vector2 originPosition;

	// Use this for initialization
	void Start () {
        Spawn();
	}
	
    void Spawn ()
    {
    }
}
