using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("more than 1 buildmanager in scene!");
        }

        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missleLauncherPrefab;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }

    public bool HasMoney { get { return PlayerStats.money >= turretToBuild.cost; } }

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.money < turretToBuild.cost)
        {
            Debug.Log("Not enough money!");
            return;
        }

        PlayerStats.money -= turretToBuild.cost;

        Vector3 nodePosition = node.GetBuildPosition();

        //Build a turret if turret == null (i.e. not built here yet)
        GameObject turret = (GameObject) Instantiate(turretToBuild.prefab, nodePosition, Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject) Instantiate(buildEffect, nodePosition, Quaternion.identity);
        Destroy(effect, 5f);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
