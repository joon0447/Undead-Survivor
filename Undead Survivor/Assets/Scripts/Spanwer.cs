using System;
using UnityEngine;

public class Spanwer : MonoBehaviour
{
    public Transform[] spawnPoint;
    float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.2f)
        {
            timer = 0;
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject enmey = GameManager.instance.pool.Get(UnityEngine.Random.Range(0, 2));
        enmey.transform.position = spawnPoint[UnityEngine.Random.Range(1,spawnPoint.Length)].position;
    }
}
