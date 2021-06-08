namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName() => name;

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public float GetHealth() => health;

        public float GetShield() => shield;

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict =- shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            if(powerUp == PowerUp.Health)
            {
                health += gain;
                if(health > 100) health = 100;
            }
            else if(powerUp == PowerUp.Shield)
            {
                shield += gain;
                if(shield > 100) shield = 100;
            }
        }
    }
}