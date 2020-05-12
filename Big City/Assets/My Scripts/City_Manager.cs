using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Manager : MonoBehaviour
{

    public int citySizeX, citySizeY, citySizeZ;
    public bool[,,] cityGrid;

    public int towers;

    public GameObject towerBase;

    void Start()
    {
        cityGrid = new bool[citySizeX, citySizeY, citySizeZ];

        for (int i = 0; i < towers; i++)
        {
            Instantiate(towerBase, new Vector3(Random.Range(0, citySizeX), transform.position.y, Random.Range(0, citySizeZ)), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
