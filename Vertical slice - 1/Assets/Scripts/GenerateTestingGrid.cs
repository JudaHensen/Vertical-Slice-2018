using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTestingGrid : MonoBehaviour {

    public GameObject cube;
    Vector3 pos = new Vector3(0f, 0f, 0f);

    void Start () {

        GenerateGrid(20, 20, 20);

	}
	

	void GenerateGrid (int sX, int sY, int sZ) {

        for (int x = 0; x < sX; x++)
        {
            pos = new Vector3(x * 5, pos.y, pos.z);

            GameObject obj = Instantiate(cube, pos, Quaternion.identity);
            obj.transform.parent = transform;

            for (int z = 0; z < sZ; z++)
            {
                pos = new Vector3(pos.x, pos.y, z * 5);

                obj = Instantiate(cube, pos, Quaternion.identity);
                obj.transform.parent = transform;

                for (int y = 0; y < sY; y++)
                {
                    pos = new Vector3(pos.x, y * 5, pos.z);

                    obj = Instantiate(cube, pos, Quaternion.identity);
                    obj.transform.parent = transform;
                }
            }
        }

    }
}
