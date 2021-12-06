using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float SpawnTimeLowerBound = 3.0f;
    public float SpawnTimeHigherBound = 6.0f;
    public GameObject SmallEnemy;
    private float nextActionTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(SmallEnemy, transform);
        nextActionTime = GetRandomPeriod();
    }

    // Update is called once per frame
    void Update()
    {
        if (nextActionTime <= Time.time)
        {
            GameObject go = Instantiate(SmallEnemy, transform);
            
            nextActionTime = Time.time + GetRandomPeriod();
        }
    }

    float GetRandomPeriod()
    {
        return Random.Range(SpawnTimeLowerBound, SpawnTimeHigherBound);
    }
}
