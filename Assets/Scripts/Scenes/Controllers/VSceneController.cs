using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class VSceneController : MonoBehaviour
{
    private INavigationController navigationController;

    public void SetNavigationController(INavigationController navigationController)
    {
        this.navigationController = navigationController;
    }

    protected void LoadScene(VScene scene)
    {
        if (navigationController == null)
        {
            return;
        }

        navigationController.LoadScene(scene);
    }
}
