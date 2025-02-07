using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony138 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony138";
        public override double halfLife { get; } = 0.348d;
        public override double atomicWeight { get; } = 137.94133d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.72d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium138()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    