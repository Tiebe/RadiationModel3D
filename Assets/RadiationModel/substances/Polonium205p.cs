using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium205p : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium205p";
        public override double halfLife { get; } = 0.0574d;
        public override double atomicWeight { get; } = 204.98276d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium205()), new(0.0587d, new GammaParticle(161030.0, 0.0077)), new(0.9349d, new GammaParticle(580900.0, 0.00213)), new(0.9859399999999999d, new GammaParticle(719300.0, 0.00172)), new(0.3242615155827398d, new GammaParticle(13292.0, 0.09328)), new(0.19716643632488265d, new GammaParticle(76862.0, 0.01613)), new(0.32833711294734824d, new GammaParticle(79290.0, 0.01564)), new(0.11303737673132655d, new GammaParticle(89837.0, 0.0138)), new(0.1481920008947691d, new GammaParticle(90941.0, 0.01363)), new(0.03515462416344256d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    