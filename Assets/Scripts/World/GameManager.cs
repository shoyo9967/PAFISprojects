using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance { get; private ser; }

    public int gunAmmo = 10;

    private void Awake()
    {
        Instance = this;
    }
}

