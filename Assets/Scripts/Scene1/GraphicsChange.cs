using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsChange : MonoBehaviour
{
    public GameObject wallPrefab;
    public WallPlacer walls;
    public bool wallsOn = true;
    void Start()
    {
        WallsOn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WallsOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WallsOn();
        }
    }

    public void WallsOff()
    {
        MeshRenderer mesh = wallPrefab.transform.GetChild(0).GetComponent<MeshRenderer>();
        mesh.enabled = false;
        for(int i = 0; i < walls.wallList.Count; ++i)
        {
            MeshRenderer mesh1 = walls.wallList[i].transform.GetChild(0).GetComponent<MeshRenderer>();
            mesh1.enabled = false;
        }
    }

    public void WallsOn()
    {
        MeshRenderer mesh = wallPrefab.transform.GetChild(0).GetComponent<MeshRenderer>();
        mesh.enabled = true;
        for (int i = 0; i < walls.wallList.Count; ++i)
        {
            MeshRenderer mesh1 = walls.wallList[i].transform.GetChild(0).GetComponent<MeshRenderer>();
            mesh1.enabled = true;
        }
    }

    public void Change()
    {
        if (wallsOn)
        {
            WallsOff();
        }
        else
        {
            WallsOn();
        }
        wallsOn = !wallsOn;
    }
}
