using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

public class VSceneFactory
{
    private static VSceneFactory instance;

    private Hashtable sceneCache;

    private VSceneFactory()
    {
        sceneCache = new Hashtable();
    }

    public static VSceneFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new VSceneFactory();
            }

            return instance;
        }
    }

    public VScene FirstScene()
    {
        return new VScene("Prefabs/FirstScene");
    }

    public VScene SecondScene(Color color)
    {
        return new VSecondScene(color, "Prefabs/SecondScene");
    }
}
