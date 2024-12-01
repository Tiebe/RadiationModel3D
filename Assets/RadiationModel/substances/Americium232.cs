using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium232";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 232.04661d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.97d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium232()) } },
            { 0.03d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium228()), new(1.0d, new AlphaParticle(8187002.09)) } },
            { 0.0006900000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium232()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    