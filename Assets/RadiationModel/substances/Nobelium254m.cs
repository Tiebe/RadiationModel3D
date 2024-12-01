using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254m";
        public override double halfLife { get; } = 0.265d;
        public override double atomicWeight { get; } = 254.09235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium254()) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.0001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium250()), new(1.0d, new AlphaParticle(10544002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    