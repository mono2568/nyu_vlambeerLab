using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    public GameObject wallTile;
    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!check && GameObject.FindGameObjectsWithTag("PathmakerSphere").Length == 0) {
            check = true;
            for (int i = -1; i <= 1; i++) {
                for (int j = -1; j <= 1; j++) {
                    Collider[] hitColliders = Physics.OverlapSphere(this.transform.position + new Vector3(i*5,0, j * 5), 0.5f);

                    // AVOID SPAWNING A TILE IN THE SAME PLACE AS ANOTHER TILE 
                    if (hitColliders.Length == 0)
                    {
                        Instantiate(wallTile, this.transform.position + new Vector3(i * 5,0, j * 5), Quaternion.Euler(0, 0, 0));
                    }
                }
            }
        }
    }
}
