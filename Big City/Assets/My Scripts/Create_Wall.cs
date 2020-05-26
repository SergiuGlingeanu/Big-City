using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Wall : MonoBehaviour
{
    public int maxHeight;
    public GameObject[] blocks;

    private void Start()
    {
        for (int i = 0; i < maxHeight; i++)
        {
            Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(transform.position.x, transform.position.y + i, transform.position.z), Quaternion.identity);
        }
    }
}
