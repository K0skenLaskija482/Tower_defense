
using UnityEngine;

namespace Pienharjoitukset
{
    public class EnemyMovement : MonoBehaviour
    {
        public Transform tower;          // Tornin sijainti
        public Transform enemy;          // Vihollisen sijainti
        public float speed = 5f;         // Vihollisen liikkumisnopeus

        void Update()
        {
            // Lasketaan suunta tornia kohti
            Vector3 direction = tower.position - enemy.position;

            // Normalisoidaan suuntavektori, jotta liike on tasainen
            Vector3 directionNormalized = direction.normalized;

            // Liikutetaan vihollista kohti tornia nopeudella speed
            enemy.position += directionNormalized * speed * Time.deltaTime;
        }
    }
}
