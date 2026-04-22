using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class disable : MonoBehaviour
{
    public ObjectSpawner spawner;

    void Start()
    {
        if (spawner == null)
            spawner = GetComponent<ObjectSpawner>();

        // Subscribe to the spawned event directly — no child count needed
        spawner.objectSpawned += OnObjectSpawned;
    }

    void OnDestroy()
    {
        if (spawner != null)
            spawner.objectSpawned -= OnObjectSpawned;
    }

    void OnObjectSpawned(GameObject obj)
    {
        spawner.enabled = false;
        Debug.Log("Spawner Disabled After First Placement");
    }
}