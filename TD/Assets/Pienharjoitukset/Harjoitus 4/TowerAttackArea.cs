using System;
using TMPro;
using UnityEngine;

namespace Pienharjoitukset
{
    public class TowerAttackArea : MonoBehaviour
    {
        public TextMeshProUGUI vihollisetTeksti; // UI teksti

        private static int vihollisiaAlueella = 0;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                vihollisiaAlueella++;
                PaivitaTeksti();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                vihollisiaAlueella--;
                PaivitaTeksti();
            }
        }

        void PaivitaTeksti()
        {
            vihollisetTeksti.text = "Hyökkäysalueella on " + vihollisiaAlueella + " vihollista";
        }
    }
}
