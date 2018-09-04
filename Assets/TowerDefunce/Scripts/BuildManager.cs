
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("more than one BuildManager in scene!");
            return;
        }
        instance = this;
    }
 

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    
    public GameObject turretToBuild;
    
    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
}
