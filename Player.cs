using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    public  float speed = 4f;

    public Transform playerVisual;

    public void Awake()
    {
        playerVisual = GameObject.Find("PlayerVisual").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //移动wasd
    public void Move()
    {
        float moveHorizontal=Input.GetAxisRaw("Horizontal");//水平
        float moveVertical=Input.GetAxisRaw("Vertical");//竖直
        Vector2 moveMent=new Vector2(moveHorizontal,moveVertical);
        moveMent.Normalize();//向量归一化
        transform.Translate(translation: (Vector3)(moveMent * speed * Time.deltaTime));
        turnaround(moveHorizontal);
    }
    //转头
    public void turnaround(float h)
    {
        if (h == -1)
        {
            playerVisual.localScale=new Vector3(x:-1,playerVisual.localScale.y,playerVisual.localScale.z);
        }
        else if (h == 1)
        {
            playerVisual.localScale = new Vector3(x:1,playerVisual.localScale.y,playerVisual.localScale.z);
        }
    }
    //受伤
    public void Injuired(float attack)
    {
        
    }
    
    //攻击
    public void Attack()
    {
        
    }
    //死亡
    public void Dead()
    {
        
    }
}
