using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver94n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94n";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 93.95072d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9540000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium94()) } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium93()), new(1.0d, new ProtonParticle()) } },
            { 0.040999999999999995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium93()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    