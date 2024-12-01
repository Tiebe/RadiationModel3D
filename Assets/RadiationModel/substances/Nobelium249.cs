using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium249";
        public override double halfLife { get; } = 0.0381d;
        public override double atomicWeight { get; } = 249.08781d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium245()), new(1.0d, new AlphaParticle(10197002.09)) } },
            { 0.0023d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    