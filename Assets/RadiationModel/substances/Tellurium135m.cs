using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium135m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 134.91822d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium135()), new(0.04511999999999999d, new GammaParticle(50000.0, 0.0248)), new(0.96d, new GammaParticle(325000.0, 0.00381)), new(1.008d, new GammaParticle(1180300.0, 0.00105)), new(0.0702597249792d, new GammaParticle(4135.0, 0.29984)), new(0.10020362128956474d, new GammaParticle(27202.0, 0.04558)), new(0.18659892232693623d, new GammaParticle(27473.0, 0.04513)), new(0.05340136103820797d, new GammaParticle(31093.0, 0.03988)), new(0.06498945638349911d, new GammaParticle(31359.0, 0.03954)), new(0.011588095345291129d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    