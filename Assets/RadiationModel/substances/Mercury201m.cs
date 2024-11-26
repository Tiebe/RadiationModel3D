using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury201m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury201m";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 200.97113d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury201()), new(0.01353d, new GammaParticle(26273.8, 0.04719)), new(0.20800000000000002d, new GammaParticle(218900.0, 0.00566)), new(0.9762000000000001d, new GammaParticle(521050.0, 0.00238)), new(0.49875755235066d, new GammaParticle(11777.0, 0.10528)), new(0.16137842807717803d, new GammaParticle(68894.0, 0.018)), new(0.2735691271015054d, new GammaParticle(70820.0, 0.01751)), new(0.09284263358802523d, new GammaParticle(80316.0, 0.01544)), new(0.12004552522931661d, new GammaParticle(81285.0, 0.01525)), new(0.027202891641291395d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    