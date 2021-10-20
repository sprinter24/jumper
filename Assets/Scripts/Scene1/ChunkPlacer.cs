using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Transform LavaLake;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    [SerializeField] private float chunkSpawnDistance = 5f;
    private List<Chunk> SpawnedChunks = new List<Chunk>();

    void Start()
    {
        SpawnedChunks.Add(FirstChunk);
    }

    
    void Update()
    {
        if(Player.position.y > SpawnedChunks[SpawnedChunks.Count - 1].End.position.y - chunkSpawnDistance)
        {
            ChunkSpawn();
        }
        if(LavaLake.position.y > SpawnedChunks[0].End.transform.position.y)
        {
            Destroy(SpawnedChunks[0].gameObject);
            SpawnedChunks.RemoveAt(0);
        }
    }

    private void ChunkSpawn()
    {
        Chunk NewChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        NewChunk.transform.position = SpawnedChunks[SpawnedChunks.Count - 1].End.position - NewChunk.Begin.localPosition;
        SpawnedChunks.Add(NewChunk);
    }
}
