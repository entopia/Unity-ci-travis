using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    static Vector3 position;
    void Start()
    {
        transformthecube();
    }

    void transformthecube()
    {
        cube.transform.position = new Vector3(1, 1, 5);
        position = cube.transform.position;
        get_object_position(position);
    }

    public static Vector3 get_object_position(Vector3 position)
    {
        return (position);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
