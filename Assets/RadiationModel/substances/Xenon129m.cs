using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon129m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon129m";
        public override double halfLife { get; } = 767232.0d;
        public override double atomicWeight { get; } = 128.90503d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon129()), new(0.075d, new GammaParticle(39578.0, 0.03133)), new(0.045899999999999996d, new GammaParticle(196560.0, 0.00631)), new(0.159192132d, new GammaParticle(4540.0, 0.27309)), new(0.3606221034037695d, new GammaParticle(29458.0, 0.04209)), new(0.6680661419113921d, new GammaParticle(29778.0, 0.04164)), new(0.19366970443757134d, new GammaParticle(33726.0, 0.03676)), new(0.23937575468483815d, new GammaParticle(34030.0, 0.03643)), new(0.04570605024726684d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    