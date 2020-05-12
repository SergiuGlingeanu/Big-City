using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Manager : MonoBehaviour
{

    public int citySizeX, citySizeY, citySizeZ;
    public bool[,,] cityGrid;

    public int towers;

    public GameObject towerBase, cityGround;

    void Start()
    {
        cityGrid = new bool[citySizeX, citySizeY, citySizeZ];

        for (int i = 0; i < towers; i++)
        {
            Instantiate(towerBase, new Vector3(Random.Range(0, citySizeX), transform.position.y, Random.Range(0, citySizeZ)), Quaternion.identity);
        }

        cityGround.transform.localScale = new Vector3(citySizeX/5, 1, citySizeZ/5);

        Instantiate(cityGround, new Vector3(citySizeX / 2, transform.position.y, citySizeZ / 2), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
