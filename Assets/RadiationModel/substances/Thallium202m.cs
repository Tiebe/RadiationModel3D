using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium202m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium202m";
        public override double halfLife { get; } = 0.00059d;
        public override double atomicWeight { get; } = 201.97313d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium202()), new(0.8919d, new GammaParticle(459720.0, 0.0027)), new(0.9712999999999999d, new GammaParticle(490470.0, 0.00253)), new(0.039310004431432d, new GammaParticle(12148.0, 0.10206)), new(0.021074644418647936d, new GammaParticle(70832.0, 0.0175)), new(0.03557502433937869d, new GammaParticle(72874.0, 0.01701)), new(0.012098657090187646d, new GammaParticle(82629.0, 0.015)), new(0.015691958245973376d, new GammaParticle(83631.0, 0.01483)), new(0.003593301155785731d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    