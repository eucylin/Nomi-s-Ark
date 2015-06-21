//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2015 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;

/// <summary>
/// Simple example of an OnDrop event accepting a game object. In this case we check to see if there is a DragDropObject present,
/// and if so -- create its prefab on the surface, then destroy the object.
/// </summary>

[AddComponentMenu("NGUI/Examples/Drag and Drop Surface (Example)")]
public class ExampleDragDropSurface : MonoBehaviour
{
	public bool rotatePlacedObject = false;
    public string targetName;
    public GameObject prefab_Particle;
    public int maxPuzzlePieces = 1; 
    void OnDrop(GameObject go)
    {
        targetName = this.gameObject.name;
        ExampleDragDropItem ddo = go.GetComponent<ExampleDragDropItem>();

        if (ddo != null && ddo.gameObject.name == targetName)
        {
            Sprite original_sprite = ddo.transform.GetChild(0).GetComponent<UI2DSprite>().sprite2D;
            //GameObject child = NGUITools.AddChild(gameObject, m_sprite);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = original_sprite;
            this.GetComponent<Collider>().enabled = false;

            Instantiate(prefab_Particle, transform.position, transform.rotation);
            Camera.main.GetComponent<AudioSource>().Play();
            //Transform trans = child.transform;
            //trans.position = UICamera.lastWorldPosition;
            //if (rotatePlacedObject) trans.rotation = Quaternion.LookRotation(UICamera.lastHit.normal) * Quaternion.Euler(90f, 0f, 0f);
            if (GameController.Instance.puzzleCount < maxPuzzlePieces - 1)
                GameController.Instance.puzzleCount += 1;
            else
                Debug.Log("EndGAME");
            Destroy(go);
        }
    }
}
