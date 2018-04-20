using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class VScene
{
    public GameObject GameObject { get; private set; }

    public VScene(String prefab)
    {
        this.GameObject = UnityEngine.Object.Instantiate(Resources.Load(prefab) as GameObject);
    }

    public void AttachTo(GameObject parent, INavigationController navigationController)
    {
        GameObject.transform.parent = parent.transform;
        GameObject.transform.localPosition = Vector3.zero;
        GameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);

        VSceneController sceneController = GameObject.GetComponent<VSceneController>();
        sceneController.SetNavigationController(navigationController);
    }

    public void Detach()
    {
        VSceneController sceneController = GameObject.GetComponent<VSceneController>();
        sceneController.SetNavigationController(null);
        GameObject.transform.parent = null;

        UnityEngine.Object.Destroy(GameObject);
    }
}
