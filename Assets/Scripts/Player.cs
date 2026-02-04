using NamruUtilitySuite;
using UnityEngine;

public class Player : NUS_Object
{
    public static Player Instance;

    [SerializeField] private Collider _capsuleColider;

    private void Awake()
    {
        LogInc("Awake()", LogDestination.Hidden, NAMRU_LogType.UnityAPI);

        Instance = this;

        NamruLogManager.DecrementTabLevel();
    }

    void Start()
    {
        LogInc("Start()", LogDestination.Hidden, NAMRU_LogType.UnityAPI);

        _capsuleColider.GetComponent<MeshRenderer>().enabled = false;

        NamruLogManager.DecrementTabLevel();
    }

    void Update()
    {
        
    }
}
