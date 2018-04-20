using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneController : VSceneController
{
    public void OnRedClicked()
    {
        LoadScene(VSceneFactory.Instance.SecondScene(Color.red));
    }

    public void OnGreenClicked()
    {
        LoadScene(VSceneFactory.Instance.SecondScene(Color.green));
    }

    public void OnBlueClicked()
    {
        LoadScene(VSceneFactory.Instance.SecondScene(Color.blue));
    }
}
