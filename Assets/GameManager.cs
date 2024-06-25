using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// This is a static instance of this class, GameManager - there can only be.
    /// </summary>
public static GameManager instance;

    public List<PlayerControlller> players;
    // Prefabs
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;
    public Transform playerSpawnTransform;
    #endregion

    public PlayerControlller playerOne;
    public TankPawn newTankPawn;

    private void Awake()
    {
        SpawnPlayer();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
        players = new List<PlayerControlller>();

    }

      // This will spawn the player
    private void Start()
    {
        
    }

    
    public void SpawnPlayer()
    {

        // Will Spawn the player controller at (0,0,0) with no roation
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);
        // Instantiate will spawn the object and Vector3 just means (0,0,0)
        newPlayerObj.name = "Player 1";

        // Will spawn the pawn and connect it to the controller 
        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation);
        newPawnObj.name = "Player 1's tank";

        // Get the PlayerController component and Pawn component
        Controller newController = newPlayerObj.GetComponent<Controller>();

        Pawn newPawn = newPlayerObj.GetComponent<Pawn>();

        // This will Hook them up together
        newController.pawn = newPawn;
        playerOne = newController as PlayerControlller;
        Debug.Log(playerOne);
        // ^Will add in playerSpawn later

        // Get the PlayerController componet and Pawn component 

    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
