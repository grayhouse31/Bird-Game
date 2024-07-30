using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public List<GameObject> wallPrefabs;
    public float spawnTerm = 4;
    public TextMeshProUGUI scoreLabel;
    public float score;
    private float spawnTimer;
    public float ceilingY = 0.5f;
    public float floorY = -0.5f;
    public string Wall2 = "Wall2"; // °¡½Ã¹ç ÇÁ¸®ÆÕ ÀÌ¸§


    public void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;
        scoreLabel.text = ((int)score).ToString();

        if(spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            SpawnWall();

        }
    }

    private void SpawnWall()
    {
        int index = Random.Range(0, wallPrefabs.Count);
        GameObject prefabToSpawn = wallPrefabs[index];
        GameObject obj = Instantiate(wallPrefabs[index]);

        if(prefabToSpawn.name == Wall2)
        {
            float yPos = (Random.value > 0.5f) ? ceilingY : floorY;
            obj.transform.position = new Vector2(10, yPos);
        }
        else
        {
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
        }
        
    }
}
