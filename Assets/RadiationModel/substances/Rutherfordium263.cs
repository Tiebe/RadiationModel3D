using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium263";
        public override double halfLife { get; } = 600.0d;
        public override double atomicWeight { get; } = 263.11246d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium259()), new(1.0d, new AlphaParticle(9278002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    