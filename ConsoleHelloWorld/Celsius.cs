namespace ConsoleHelloWorld
{
    struct Celsius
    {
        private float degrees;
        public float Degrees
        {
            get
            {
                return this.degrees;
            }
        }

        public Celsius(float temperature)
        {
            this.degrees = temperature;
        }

        public static Celsius operator +(Celsius x, Celsius y)
        {
            return new Celsius(x.Degrees + y.Degrees);
        }

        public static implicit operator float(Celsius c)
        {
            return c.Degrees;
        }
    }
}
