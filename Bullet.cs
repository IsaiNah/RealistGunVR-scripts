using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // SimpleShoot _simpleShoot;

    //public void SetSimpleShoot(SimpleShoot simpleShoot) => _simpleShoot = simpleShoot;
    private float timeTillDesroyed = 5.0f;



    private void Awake()
    {
        StartCoroutine(BulletDidNotHit());
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bullet onCollision with " + collision.gameObject );
        gameObject.SetActive(false);
        SimpleShoot.Instance.AddBulletToPool(this);
       // _simpleShoot.addToPool(this);
    }

   public void BulletSetActive()
    {
        Debug.Log("Bullet setACtive");        
        gameObject.SetActive(true);
        StartCoroutine(BulletDidNotHit());
    }

    private IEnumerator BulletDidNotHit()
    {
        yield return new WaitForSeconds(5.0f);
        gameObject.SetActive(false);
        SimpleShoot.Instance.AddBulletToPool(this);
    }

}
