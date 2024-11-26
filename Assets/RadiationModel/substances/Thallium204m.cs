using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium204m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium204m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 203.97505d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium204()), new(0.9570000000000001d, new GammaParticle(414100.0, 0.00299)), new(0.965d, new GammaParticle(689900.0, 0.0018)), new(0.0228318258732d, new GammaParticle(12148.0, 0.10206)), new(0.014713262565982465d, new GammaParticle(70832.0, 0.0175)), new(0.024836702508410646d, new GammaParticle(72874.0, 0.01701)), new(0.008446677197846485d, new GammaParticle(82629.0, 0.015)), new(0.01095534032560689d, new GammaParticle(83631.0, 0.01483)), new(0.002508663127760406d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    