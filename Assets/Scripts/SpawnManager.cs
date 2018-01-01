using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public int maxPlatforms = 20;
    public GameObject platformLeft;
    public GameObject platformRight;

    private Vector3 leftPosition;
    private Vector3 rightPosition;

	// Use this for initialization
	void Start () {
        leftPosition = platformLeft.transform.position;
        rightPosition = platformRight.transform.position;
        Spawn();
	}
	
    void Spawn ()
    {
        float miny = -4f;
        float maxy = 7f;
        SpawnPlatformRandom(new Vector3(leftPosition.x, Random.Range(miny, maxy), 0), new Vector2(3f, 0));
        SpawnPlatformRandom(new Vector3(rightPosition.x, Random.Range(miny, maxy), 0), new Vector2(-3f, 0));
        Invoke("Spawn", 3f);

    }

    private void SpawnPlatformRandom(Vector3 position, Vector2 velocity)
    {
        var platty = Instantiate(platformLeft, position, Quaternion.identity);
        platty.transform.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
