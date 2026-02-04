using NamruUtilitySuite;
using UnityEngine;

public class DataManager : NUS_Object
{
    public static DataManager Instance;

    private void Awake()
    {
        LogInc($"Awake()",LogDestination.Hidden, NAMRU_LogType.UnityAPI);

        Instance = this;

        NamruLogManager.DecrementTabLevel();
    }

    void Start()
    {
        LogInc($"Start()", LogDestination.Hidden, NAMRU_LogType.UnityAPI);

        NamruLogManager.DecrementTabLevel();

    }

    void Update()
    {
        
    }
}
