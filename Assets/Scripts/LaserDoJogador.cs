using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDoJogador : MonoBehaviour
{
    public GameObject impactoDoLsarDoJogador;
    public float velocidadeDoLaser;
    public int danoParaDar;

    void Start()
    {

    }

    void Update()
    {
        MovimentarLaser();
    }
    private void MovimentarLaser()
    {
        transform.Translate(Vector3.up * velocidadeDoLaser * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            collision.gameObject.GetComponent<Inimigos>().MachucarInimigo(danoParaDar);
            Instantiate(impactoDoLsarDoJogador, transform.position, transform.rotation);
            EfeitosSonoros.instance.somDeImpacto.Play();
            Destroy(this.gameObject);
        }
    }
}
