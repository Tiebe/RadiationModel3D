using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon127 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon127";
        public override double halfLife { get; } = 3140294.4d;
        public override double atomicWeight { get; } = 126.90518d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine127()), new(0.0122973d, new GammaParticle(57610.0, 0.02152)), new(0.0431436d, new GammaParticle(145252.0, 0.00854)), new(0.256938d, new GammaParticle(172132.0, 0.0072)), new(0.687d, new GammaParticle(202860.0, 0.00611)), new(0.173124d, new GammaParticle(374991.0, 0.00331)), new(0.000142896d, new GammaParticle(618400.0, 0.002)), new(0.09790769474598832d, new GammaParticle(4335.0, 0.28601)), new(0.2514245891978712d, new GammaParticle(28318.0, 0.04378)), new(0.46698474962457504d, new GammaParticle(28613.0, 0.04333)), new(0.13454060700948914d, new GammaParticle(32395.0, 0.03827)), new(0.16494678419363368d, new GammaParticle(32680.0, 0.03794)), new(0.030406177184144543d, new GammaParticle(33040.0, 0.03753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    