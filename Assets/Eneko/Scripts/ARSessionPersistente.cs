using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARSessionPersistente : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
