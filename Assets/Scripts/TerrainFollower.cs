using UnityEngine;

public class TerrainFollower : MonoBehaviour
{
    public Transform target; // Drag your animated player here
    private Terrain terrain;

    void Start()
    {
        terrain = GetComponent<Terrain>();

        if (terrain == null)
        {
            Debug.LogError("TerrainFollower: No Terrain component found!");
        }

        if (target == null)
        {
            Debug.LogError("TerrainFollower: No target assigned!");
        }
    }

    void LateUpdate()
    {
        if (terrain == null || target == null) return;

        Vector3 terrainSize = terrain.terrainData.size;

        // Calculate position to center the terrain under the target
        float offsetX = -terrainSize.x * 0.5f;
        float offsetZ = -terrainSize.z * 0.5f;

        Vector3 newPos = new Vector3(
            target.position.x + offsetX,
            transform.position.y, // Keep terrain height constant
            target.position.z + offsetZ
        );

        transform.position = newPos;
    }
}
