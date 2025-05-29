using UnityEngine;

public class TempoAnalyzer : MonoBehaviour
{
    [Tooltip("Kappaleen tempo (BPM)")]
    public float BPM = 120f;

    // Kuinka usein esteitä tai esineitä syntyy (sekunteina)
    public float SpawnInterval => 60f / BPM;
}
