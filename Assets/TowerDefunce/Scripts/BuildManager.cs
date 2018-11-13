
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake ()
    {
        instance = this;

        if (instance == null)
        {
            Awake();
        }
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
