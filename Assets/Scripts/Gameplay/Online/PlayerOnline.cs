using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerOnline : NetworkBehaviour
{
    [SerializeField] private GameObject playerController;
    void Start()
    {
        if(!IsLocalPlayer)
        {
            Destroy(playerController);
            enabled = false;
        }
    }
}
