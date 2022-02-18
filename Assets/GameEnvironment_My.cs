using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// sealed : sealed 修飾子をクラスに適用すると、それ以外のクラスが、そのクラスから継承できなくなる
public sealed class GameEnvironment_My
{
    // Create an instance of the GameEnvironment class called 'instance'.
    private static GameEnvironment_My instance;

    // Create a list of game objects called 'checkpoints'
    private List<GameObject> checkpoints = new List<GameObject>();

    // Create public reference for retrieving checkpoints list.
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    // Create singleton if it doesn't already exist and populate list with any objects found with tag set to "Checkpoint".
    public static GameEnvironment_My Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new GameEnvironment_My();
                //  AddRange : Listの末尾に複数の要素を追加
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return instance;
        }
    }

}
