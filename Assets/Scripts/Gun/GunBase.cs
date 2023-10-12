using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    /*
    // código da aula**
    public ProjectileBase prefabProjectile;

    public Transform positionToShoot;
    public float timeBetweenShoot = .3f;
    public Transform playerSideReference;

    private Coroutine _currentCoroutine;

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            _currentCoroutine = StartCoroutine(StarShoot());

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            if (_currentCoroutine !=null) 
                StopCoroutine(_currentCoroutine);
        }
    }

    IEnumerator StarShoot()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(timeBetweenShoot);
        }
    }



    public void Shoot()
    {
        var projectile = Instantiate(prefabProjectile);
        projectile.transform.position = positionToShoot.position;
        projectile.side = playerSideReference.transform.localScale.x;
    }
}*/

        
        public ProjectileBase prefabProjectile;
        public Transform positionToShoot;
        public float timeBetweenShoot = .3f;
        public Transform playerSideReference;
        private Coroutine _currentCoroutine;

        private bool isShooting = false; // Adiciona uma variável para rastrear se está atirando.

        public AudioRandomPlayAudioClips randomShoot;    

    public void Awake()
    {
        playerSideReference = GameObject.FindObjectOfType<Player>().transform;
    }


    void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                isShooting = true; // Indica que estamos atirando.

                // Iniciamos a coroutine apenas uma vez.
                if (_currentCoroutine == null)
                {
                    _currentCoroutine = StartCoroutine(StarShoot());
                }
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                isShooting = false; // Indica que não estamos atirando mais.

                if (_currentCoroutine != null)
                {
                    StopCoroutine(_currentCoroutine);
                    _currentCoroutine = null; // Garantimos que a coroutine seja interrompida e a referência limpa.
                }
            }
        }

        IEnumerator StarShoot()
        {
            while (isShooting) // Verificamos a variável isShooting em vez de true.
            {
                Shoot();
                yield return new WaitForSeconds(timeBetweenShoot);
            }
        }

        public void Shoot()
        {
            if (randomShoot != null) randomShoot.PlayRandom();
            
            var projectile = Instantiate(prefabProjectile);
            projectile.transform.position = positionToShoot.position;
            projectile.side = playerSideReference.transform.localScale.x;
        }
    }