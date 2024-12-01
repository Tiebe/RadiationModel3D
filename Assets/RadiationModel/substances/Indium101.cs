using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium101";
        public override double halfLife { get; } = 15.1d;
        public override double atomicWeight { get; } = 100.92641d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver101()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    