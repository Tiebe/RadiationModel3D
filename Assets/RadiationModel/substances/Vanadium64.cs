using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium64";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 63.98248d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium64()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.2d, new GammaParticle(430000.0, 0.00288)) } },
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
    