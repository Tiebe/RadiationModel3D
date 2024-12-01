using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium254";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 254.10005d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium250()), new(1.0d, new AlphaParticle(10227002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    