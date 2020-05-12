using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Tower : MonoBehaviour
{

    public int maxHeight, heightBeforeChange;
    public GameObject[] blocks;

    private City_Manager cityManager;

    void Start()
    {
        cityManager = GameObject.Find("Game Manager").GetComponent<City_Manager>();

        for (int i = 0; i < maxHeight; i++)
        {
            int luck = Random.Range(0, 10);

            if (i > heightBeforeChange && luck > 0)
            {
                ExpandHorizontally(i);
            }

            Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }

    private void ExpandHorizontally(int i)
    {
        int direction = Random.Range(1, 5);
        switch (direction)
        {
            case 1:
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x + 1, transform.position.y + i, transform.position.z), Quaternion.identity);
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x + 2, transform.position.y + i, transform.position.z), Quaternion.identity);
                MakeSectionTaller(new Vector3(transform.position.x + 2, transform.position.y + i, transform.position.z));
                break;
            case 2:
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x - 1, transform.position.y + i, transform.position.z), Quaternion.identity);
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x - 2, transform.position.y + i, transform.position.z), Quaternion.identity);
                MakeSectionTaller(new Vector3(transform.position.x - 2, transform.position.y + i, transform.position.z));
                break;
            case 3:
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z + 1), Quaternion.identity);
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z + 2), Quaternion.identity);
                MakeSectionTaller(new Vector3(transform.position.x, transform.position.y + i, transform.position.z + 2));
                break;
            case 4:
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z - 1), Quaternion.identity);
                Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z - 2), Quaternion.identity);
                MakeSectionTaller(new Vector3(transform.position.x, transform.position.y + i, transform.position.z - 2));
                break;
        }

    }

    private void MakeSectionTaller(Vector3 _initialPos)
    {
        int _currentHeight = (int)_initialPos.y;

        while(_currentHeight < maxHeight - 1)
        {
            Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(_initialPos.x, _currentHeight + 1, _initialPos.z), Quaternion.identity);
            _currentHeight += 1;
        }
    }
}
