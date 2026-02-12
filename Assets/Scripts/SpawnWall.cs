using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;

    float timePassed;
    public float spawnRate;

    public float spawnOffset = 5;

    //Function that spawns walls at varied heights within a range
    void SpawnInstance()
    {
        float maxHeight = transform.position.y;
        float minHeight = transform.position.y - spawnOffset; 

        Instantiate(wall, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
    }

    void Start()
    {
        SpawnInstance();
    }

    //Spawns a new wall if its been longer than whatever the value of spawn rate
    //is set to in editor.
    void Update()
    {
        if(timePassed < spawnRate)
        {
            timePassed += Time.deltaTime;
        }
        else
        {
            SpawnInstance();
            timePassed = 0;
        }
    }
}
