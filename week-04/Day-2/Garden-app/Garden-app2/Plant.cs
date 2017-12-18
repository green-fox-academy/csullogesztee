namespace Garden_app2
{
    public abstract class Plant
    {
        protected double WaterAmount { get; set; }
        public string Color { get; private set; }

        public virtual bool NeedsWater { get; }
        private double Absorb { get; set; }
       

        protected Plant(string color, double absorb, double waterAmount)
        {
            Color = color;
            Absorb = absorb;
            WaterAmount = waterAmount;
        }

        public void Watering(double amount)
        {
            if (NeedsWater)
            {
                WaterAmount += amount * Absorb;
            }
        }
    }
}