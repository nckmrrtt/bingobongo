using UnityEngine;

public class SpawnCoin : MonoBehaviour
{

    public Transform[] coinSpawns;
    public GameObject coin;
    public static int coinCount = 0;

    // Use this for initialization
    void Start()
    {
    }

    void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int min = 0;
            int max = 5;
            int coinFlip = Random.Range(min, max);
            if (coinFlip == min)
            {
                coinCount++;
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount == 0)
        {
            Spawn();
        }
    }
}
