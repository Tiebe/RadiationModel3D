using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium183";
        public override double halfLife { get; } = 6.9d;
        public override double atomicWeight { get; } = 182.98219d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold183()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    