using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> SpawnedChunks = new List<Chunk>();

    void Start()
    {
        SpawnedChunks.Add(FirstChunk);
    }

    
    void Update()
    {
        if(Player.position.y > SpawnedChunks[SpawnedChunks.Count - 1].End.position.y - 15)
        {
            ChunkSpawn();
        }
    }

    private void ChunkSpawn()
    {
        Chunk NewChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        NewChunk.transform.position = SpawnedChunks[SpawnedChunks.Count - 1].End.position - NewChunk.Begin.localPosition;
        SpawnedChunks.Add(NewChunk);

        if(SpawnedChunks.Count >= 4)
        {
            Destroy(SpawnedChunks[0].gameObject);
            SpawnedChunks.RemoveAt(0);
        }
    }
}
