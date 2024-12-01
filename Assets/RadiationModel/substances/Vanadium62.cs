using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium62";
        public override double halfLife { get; } = 0.0336d;
        public override double atomicWeight { get; } = 61.97294d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium62()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    