﻿
using UnityEngine;


public class Node : MonoBehaviour
{
   

    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;
   
    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    //public GameObject turret = buildManager.turretToBuild;



    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;

        //Turret[] blaa = GameObject.FindObjectsOfType<Turret>();
        //GameObject turretti = Instantiate(blaa[0].gameObject);
    }

    void OnMouseDown ()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        

        if (turret != null)
        {
            Debug.Log("You cant build there! - TODO display on screen.");
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter ()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        
        rend.material.color = hoverColor;
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }

}
