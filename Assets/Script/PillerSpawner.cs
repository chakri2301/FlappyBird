using UnityEngine;

public class PillerSpawner : MonoBehaviour
{
    public GameObject piller;
    public float spawnInterval = 2f;
    float timer = 0f;
    public float spawnX = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval)
        {
            timer = 0f;
            float randomY = Random.Range(-3, 3);
            Instantiate(piller, new Vector3(spawnX, randomY, 0), piller.transform.rotation);
        }
    }
}
