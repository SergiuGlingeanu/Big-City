using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class City_Manager : MonoBehaviour
{

    public int citySizeX, citySizeY, citySizeZ, npcAmount, enemyAmount;
    public bool[,,] cityGrid;

    public int towers;

    public GameObject towerBase, cityGround, wallBase, npc, enemy;

    public NavMeshSurface surface;

    public int enemiesLeft;

    void Start()
    {
        cityGrid = new bool[citySizeX, citySizeY, citySizeZ];

        for (int i = 0; i < towers; i++)
        {
            Instantiate(towerBase, new Vector3(Random.Range(0, citySizeX), transform.position.y, Random.Range(0, citySizeZ)), Quaternion.identity);
        }

        for (int x = 0; x < citySizeX; x++)
        {
            for (int z = 0; z < citySizeZ; z++)
            {
                if (x == 0 || x == citySizeX - 1 || z == 0 || z == citySizeZ - 1)
                {
                    Instantiate(wallBase, new Vector3(x, transform.position.y, z), Quaternion.identity);
                }
            }
        }

        Invoke("UpdateMesh", 1);

        for (int i = 0; i < npcAmount; i++)
        {
            Instantiate(npc, new Vector3(Random.Range(0, citySizeX), transform.position.y + 1, Random.Range(0, citySizeZ)), Quaternion.identity);
        }

        for (int i = 0; i < enemyAmount; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(0, citySizeX), transform.position.y + 1, Random.Range(0, citySizeZ)), Quaternion.identity);
        }
        
        enemiesLeft = enemyAmount;
    }

    void Update()
    {
        if (enemiesLeft < 1)
        {
            SceneManager.LoadScene(1);
        }
    }

    void UpdateMesh()
    {
        surface.BuildNavMesh();
    }
}
