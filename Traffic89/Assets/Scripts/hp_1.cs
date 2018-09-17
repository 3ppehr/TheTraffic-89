using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_1 : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    public Controlling playerscript;
    [SerializeField]
    Sprite FullHP;
    [SerializeField]
    Sprite LowHP;
    [SerializeField]
    Sprite LowHP1;
    [SerializeField]
    Sprite LowHP2;
    [SerializeField]
    Sprite LowHP3;





    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {

        ManageHeart();
    }
    void ManageHeart()
    {
        int tmp = playerscript.Health;
        if (tmp == 3)
        {
            spriteRenderer.sprite = LowHP;
        }

        if (tmp == 2)
        {
            spriteRenderer.sprite = LowHP1;
        }

        if (tmp == 1)
        {
            spriteRenderer.sprite = LowHP2;
        }
        if (tmp == 0)
        {
            spriteRenderer.sprite = LowHP3;
        }
    }
}
