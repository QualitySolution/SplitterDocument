namespace SplitterDocument
{
    public class Bytes
    {
        byte[] mass;
        byte[] mass2;
        public byte[] result_mass { get; private set; }
        public byte[] result_mass2 { get; private set; }

        public Bytes(byte[] mass)
        {
            this.mass = mass;
        }

        public Bytes(byte[] mass, byte[] mass2)
        {
            this.mass = mass;
            this.mass2 = mass2;
        }
        public void mergeMass()
        {
            byte[] result_mass = new byte[mass.Length + mass2.Length];
            int j = 0;
            for (int i = 0; i < mass.Length + mass2.Length; i++)
            {
                result_mass[i] = mass[j];
                result_mass[++i] = mass2[j];
                j++;
            }
            this.result_mass = result_mass;
        }

        public void SplitMass()
        {
            byte[] result_mass = new byte[mass.Length / 2];
            byte[] result_mass2 = new byte[mass.Length / 2];
            int j = 0;
            for(int i = 0; i < mass.Length; i++)
            {
                result_mass[j] = mass[i];
                result_mass2[j] = mass[++i];
                j++;
            }

            this.result_mass = result_mass;
            this.result_mass2 = result_mass2;
        }
    }
}
