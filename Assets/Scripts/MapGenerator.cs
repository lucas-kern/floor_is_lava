using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    int mapSize = 20;
    public GameObject myPrefab;
    public GameObject[,] map;

    // Start is called before the first frame update
    void Start()
    {
        map = new GameObject[mapSize,mapSize];
        Debug.Log("in here");
        // map[0,1] = Instantiate(myPrefab, new Vector3(2f, 0f, 0f), Quaternion.identity);
        for(int y = 0; y < mapSize; y++){
            for(int x = 0; x < mapSize; x++){
                map[y,x] = (GameObject)Instantiate(myPrefab, new Vector3(2.1f*x, 0f, 2.1f*y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
