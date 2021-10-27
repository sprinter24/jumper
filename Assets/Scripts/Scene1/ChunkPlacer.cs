using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Transform LavaLake;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;
    public int difficultyLevels = 2;
    private List<List<Chunk>> chunksByDifficulty = new List<List<Chunk>>();

    [SerializeField] private float chunkSpawnDistance = 5f;
    private List<Chunk> SpawnedChunks = new List<Chunk>();

    public int numberOfFirstChunkSpawn = 0;

    void Start()
    {
        SpawnedChunks.Add(FirstChunk);
        FirstChunkSpawn(numberOfFirstChunkSpawn);
        for(int i = 0; i < difficultyLevels; ++i)
        {
            chunksByDifficulty.Add(new List<Chunk>());
        }
        for(int i = 0; i < ChunkPrefabs.Length; ++i)
        {
            for(int j = 0; j < difficultyLevels; ++j)
            {
                if(ChunkPrefabs[i].difficulty == j)
                {
                    chunksByDifficulty[j].Add(ChunkPrefabs[i]);
                }
            }
        }
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

    private void FirstChunkSpawn(int n)
    {
        Chunk NewChunk = Instantiate(ChunkPrefabs[n]);
        NewChunk.transform.position = SpawnedChunks[SpawnedChunks.Count - 1].End.position - NewChunk.Begin.localPosition;
        SpawnedChunks.Add(NewChunk);
    }
}
