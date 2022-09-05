using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform SpawnArea;
    public int spawnInterval;
    public int maxPowerUp;
    public List<GameObject> powerUpTemplateList;
    public Vector2 PUAreaMin;
    public Vector2 PUAreaMax;
    

    private List<GameObject> powerUpList;

    private float timer;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPU();
            timer -= spawnInterval;
            
        }
    }


    public void GenerateRandomPU()
    {
        GenerateRandomPU(new Vector2(Random.Range(PUAreaMin.x, PUAreaMax.x), Random.Range(PUAreaMin.y, PUAreaMax.y)));
    }

    public void GenerateRandomPU(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUp)
        {
            return;
        }

        if (position.x < PUAreaMin.x ||
            position.x > PUAreaMax.x ||
            position.y < PUAreaMin.y ||
            position.y > PUAreaMax.y)
        {
            return;
        }

        int RNG = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[RNG], new Vector3(position.x, position.y, powerUpTemplateList[RNG].transform.position.z),  Quaternion.identity, SpawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);

    }

    public void RemovePU (GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPU()
    {
        while (powerUpList.Count >0)
        {
            RemovePU(powerUpList[0]);
        }
    }

    
}
