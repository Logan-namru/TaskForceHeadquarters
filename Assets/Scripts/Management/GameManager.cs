using NamruUtilitySuite;
using UnityEngine;

public class GameManager : NUS_Object
{
    public static GameManager instance;

    private void Awake()
    {
        LogInc($"Awake()", LogDestination.Hidden, NAMRU_LogType.UnityAPI);

        instance = this;

        NamruLogManager.DecrementTabLevel();
    }

    void Start()
    {
        LogInc($"Awake()", LogDestination.Hidden, NAMRU_LogType.UnityAPI);



        NamruLogManager.DecrementTabLevel();
    }

    void Update()
    {
        
    }
}
