using UnityEngine;

public class TempoAnalyzer : MonoBehaviour
{
    [Tooltip("Kappaleen tempo (BPM)")]
    public float BPM = 120f;

    // Kuinka usein esteit� tai esineit� syntyy (sekunteina)
    public float SpawnInterval => 60f / BPM;
}
