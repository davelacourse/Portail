using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStart : MonoBehaviour
{

    public void StartSpaceShooter()
    {
        Debug.Log("Chemin : " + Application.dataPath);
        System.Diagnostics.Process.Start(Application.dataPath + "/../../SpaceShooter/SpaceShooter.exe");
    }

    public void StartGobelinicide()
    {
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Gobelinicide/Gobelinicide.exe");
    }
}
