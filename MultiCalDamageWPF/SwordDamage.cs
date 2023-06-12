namespace MultiCalDamageWPF
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        private int roll;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }

        }

        public bool flaming;

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }

        }

        public bool magic;

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value; CalculateDamage();
            }
        }

        public int Damage { get; private set; }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }

        public SwordDamage(int StartingRoll)
        {
            roll = StartingRoll;
            CalculateDamage();

        }
    }
}
