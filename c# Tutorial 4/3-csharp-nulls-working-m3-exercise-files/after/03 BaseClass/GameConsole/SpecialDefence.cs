namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefence Null { get; } = new NullDefence();

        /// <summary>
        /// Esto se hace para que uno pueda hacer que si algun obj es de tipo nada que no se caiga el systema
        /// </summary>
        private class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // no operation /  "do nothing" behavior
            }
        }
    }
}