using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium257";
        public override double halfLife { get; } = 19872.0d;
        public override double atomicWeight { get; } = 257.09554d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium257()), new(0.21d, new GammaParticle(20618.0, 0.06013)), new(0.09d, new GammaParticle(115320.0, 0.01075)), new(0.14d, new GammaParticle(121090.0, 0.01024)), new(0.05d, new GammaParticle(136318.0, 0.0091)), new(0.07d, new GammaParticle(138067.0, 0.00898)), new(0.019d, new GammaParticle(140406.0, 0.00883)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium253()), new(1.0d, new AlphaParticle(8579002.09)), new(0.0040999999999999995d, new GammaParticle(181300.0, 0.00684)), new(0.025d, new GammaParticle(325100.0, 0.00381)), new(0.12d, new GammaParticle(371400.0, 0.00334)), new(0.0007099999999999999d, new GammaParticle(388500.0, 0.00319)), new(0.0022591304176d, new GammaParticle(20093.0, 0.06171)), new(0.0011838845243551692d, new GammaParticle(112581.0, 0.01101)), new(0.0018213608067002601d, new GammaParticle(118057.0, 0.0105)), new(0.0007015189763951186d, new GammaParticle(132973.0, 0.00932)), new(0.0009526627699445709d, new GammaParticle(134678.0, 0.00921)), new(0.00025114379354945244d, new GammaParticle(136945.0, 0.00905)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    