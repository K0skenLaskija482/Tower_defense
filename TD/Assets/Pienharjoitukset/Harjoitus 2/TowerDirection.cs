using TMPro;
using UnityEngine;

namespace Pienharjoitukset
{
    public class TowerDirection : MonoBehaviour
    {
        public Transform tower;      // Tornin sijainti
        public Transform enemy;      // Vihollisen sijainti
        public TextMeshProUGUI directionText;   // Tekstikenttä suunnan näyttämiseen

        void Update()
        {
            // Lasketaan hyökkäyssuunta: Vihollisen sijainti - Tornin sijainti
            Vector3 direction = enemy.position - tower.position;

            // Tulostetaan suuntavektori tekstikenttään
            // Vektori näkyy muodossa (x, y, z)
            directionText.text = "Mistä suunnasta vihollinen hyökkää: " + direction.ToString();
        }
    }
}
