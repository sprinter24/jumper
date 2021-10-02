using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPlacer : MonoBehaviour
{
    [SerializeField] private float distanceToNextWall = 50f;
    [SerializeField] private float distanceBetweenWalls = 22.82f;
    [SerializeField] private int maxWalls = 6;
    [SerializeField] private Transform player;
    [SerializeField] private float lastWallPosition;

    public GameObject wall;

    public List<GameObject> wallList = new List<GameObject>();

    void Start()
    {
        wallList.Add(Instantiate(wall, new Vector3(wall.transform.position.x, lastWallPosition, wall.transform.position.z), wall.transform.rotation));
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(wallList[wallList.Count -1].transform.position.y + distanceToNextWall <= player.position.y)
        {
            if(wallList.Count > maxWalls)
            {
                Destroy(wallList[0]);
                wallList.RemoveAt(0);
            }
            wallList.Add(Instantiate(wall, new Vector3(wall.transform.position.x, lastWallPosition + distanceBetweenWalls, wall.transform.position.z), wall.transform.rotation));
            lastWallPosition += distanceBetweenWalls;
        }
    }
}
