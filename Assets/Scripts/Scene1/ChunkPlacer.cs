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
    public float difficultyIncreseFromHeight = 0.0001f;

    public List<int> minDifficultyHeight = new List<int>();
    public List<float> maxFactorOfDifficulty = new List<float>();
    private List<List<int>> chunkNumbersByDifficulty = new List<List<int>>();
    private List<int> spawnedChunksIndex = new List<int>();

    private List<List<Chunk>> chunksByDifficulty = new List<List<Chunk>>(); // may be delete

    [SerializeField] private float chunkSpawnDistance = 5f;
    private List<Chunk> SpawnedChunks = new List<Chunk>();

    public int numberOfFirstChunkSpawn = 0;

    void Start()
    {
        SpawnedChunks.Add(FirstChunk);
        FirstChunkSpawn(numberOfFirstChunkSpawn);
        spawnedChunksIndex.Add(numberOfFirstChunkSpawn); //delete together
        for(int i = 0; i <= difficultyLevels; ++i)
        {
            chunkNumbersByDifficulty.Add(new List<int>());
            chunksByDifficulty.Add(new List<Chunk>());
        }
        for (int i = 0; i < ChunkPrefabs.Length; ++i)
        {
            for (int j = 0; j <= difficultyLevels; ++j)
            {
                if (ChunkPrefabs[i].difficulty == j)
                {
                    chunkNumbersByDifficulty[j].Add(i);
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
        int difficultySpawn = 0;
        List<float> chunkRate = ChunkRate(Player.position.y);
        float wholeRate = 0;
        for(int i = 0; i <= difficultyLevels; ++i)
        {
            wholeRate += chunkRate[i];
        }
        float r = Random.Range(0, wholeRate);
        for(int i = 0; i <= difficultyLevels; ++i)
        {
            float length = 0;
            for(int j = 0; j <= i; ++j)
            {
                length += chunkRate[j]; 
            }
            if( r >= length - chunkRate[i])
            {
                difficultySpawn = i;
            }
            else
            {
                break;
            }
        }  //found difficulty for next chunk

        int nextChunkIndex = chunkNumbersByDifficulty[difficultySpawn][Random.Range(0, chunkNumbersByDifficulty.Count)];

        
        if(spawnedChunksIndex.Count == 0)
        {
            nextChunkIndex = chunkNumbersByDifficulty[difficultySpawn][Random.Range(0, chunkNumbersByDifficulty.Count)];
        }
        else
        {
            List<int> chunksWith1Difficulty = new List<int>();
            for(int i = 0; i < spawnedChunksIndex.Count; ++i)
            {
                if(ChunkPrefabs[i].difficulty == difficultySpawn)
                {
                    chunksWith1Difficulty.Add(i);
                }
            }
            if(chunkNumbersByDifficulty[difficultySpawn].Count == 1)
            {
                nextChunkIndex = chunkNumbersByDifficulty[difficultySpawn][0];
            }
            else
            {
                chunksWith1Difficulty.RemoveAt(chunksWith1Difficulty.Count - 1);
                for(int i = 0; i < chunksWith1Difficulty.Count; ++i)
                {
                    for(int j = i + 1; j < chunksWith1Difficulty.Count; ++j)
                    {
                        if(chunksWith1Difficulty[i] == chunksWith1Difficulty[j])
                        {
                            chunksWith1Difficulty.RemoveAt(j);
                        }
                    }
                }
                
                List<float> rateI = new List<float>();
                float length = 1;
                for (int i = 1; i <= chunksWith1Difficulty.Count; ++i)
                {
                    rateI.Add(Mathf.Pow(2, -i));
                    length += Mathf.Pow(2, -i);
                }
                r = Random.Range(0, length);
                if(r <= 1)
                {
                    // dopisat
                    List<int> chunksWhatNotSpawned = chunkNumbersByDifficulty[difficultySpawn];
                    for(int i = 0; i < chunksWith1Difficulty.Count; ++i) 
                    {
                        if (chunksWhatNotSpawned.Contains(chunksWith1Difficulty[i]))
                        {
                            chunksWhatNotSpawned.Remove(chunksWith1Difficulty[i]);
                        }
                    }
                    nextChunkIndex = chunksWhatNotSpawned[Random.Range(0, chunksWhatNotSpawned.Count)];
                }
                else
                {
                    r -= 1;
                    for(int i = 0; i < chunksWith1Difficulty.Count; ++i)
                    {
                        length = 0;
                        for(int j = 0; j <= i; ++j)
                        {
                            length += rateI[j];
                        }
                        if(r >= length - rateI[i])
                        {
                            nextChunkIndex = chunksWith1Difficulty[i];
                        }
                    }
                }
            }
        }

        Chunk NewChunk = Instantiate(ChunkPrefabs[nextChunkIndex]);
        NewChunk.transform.position = SpawnedChunks[SpawnedChunks.Count - 1].End.position - NewChunk.Begin.localPosition;
        spawnedChunksIndex.Add(nextChunkIndex);
        if(spawnedChunksIndex.Count > 6)
        {
            spawnedChunksIndex.RemoveAt(0);
        }
        SpawnedChunks.Add(NewChunk);
    }

    private void FirstChunkSpawn(int n)
    {
        Chunk NewChunk = Instantiate(ChunkPrefabs[n]);
        NewChunk.transform.position = SpawnedChunks[SpawnedChunks.Count - 1].End.position - NewChunk.Begin.localPosition;
        SpawnedChunks.Add(NewChunk);
    }

    private List<float> ChunkRate(float pos)
    {
        List<float> rate = new List<float>();
        for(int i = 0; i <= difficultyLevels; ++i)
        {
            rate.Add(0);
        }
        for(int i = 0; i <= difficultyLevels; ++i)
        {
            if(pos >= minDifficultyHeight[i])
            {
                rate[i] = pos * difficultyIncreseFromHeight;
                if(rate[i] > maxFactorOfDifficulty[i])
                {
                    rate[i] = maxFactorOfDifficulty[i];
                }
            }
            else
            {
                rate[i] = 0;
            }
        }
        return rate;
    }
}
