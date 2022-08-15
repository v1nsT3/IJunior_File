
    public class Weapon
    {
        private int _damage;
        private int _bullets;

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullets--;
        }
    }

    public class Player
    {
        private int _health;

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }
    }

    public class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }