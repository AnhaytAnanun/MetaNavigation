using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour, INavigationController
{
    public GameObject container;

    private VScene currentScene;

    void Start ()
    {
        VScene scene = VSceneFactory.Instance.FirstScene();
        LoadScene(scene);
	}
	
	void Update ()
    {
		
	}

    public void LoadScene(VScene scene)
    {
        if (currentScene != null)
        {
            currentScene.Detach();
        }

        currentScene = scene;
        currentScene.AttachTo(container, this);
    }
}