using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class VSecondScene : VScene
{
    private Color color;

    public VSecondScene(Color color, string prefab) : base(prefab)
    {
        this.color = color;

        SecondSceneController sceneController = this.GameObject.GetComponent<SecondSceneController>();
        sceneController.Color = this.color;
    }
}
