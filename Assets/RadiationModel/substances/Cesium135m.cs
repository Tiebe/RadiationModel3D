using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium135m";
        public override double halfLife { get; } = 3180.0d;
        public override double atomicWeight { get; } = 134.90773d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium135()), new(0.997d, new GammaParticle(787200.0, 0.00158)), new(0.96d, new GammaParticle(846100.0, 0.00147)), new(0.0039598468d, new GammaParticle(4749.0, 0.26107)), new(0.009174188622234737d, new GammaParticle(30625.0, 0.04048)), new(0.01694843639799508d, new GammaParticle(30973.0, 0.04003)), new(0.004951539372805619d, new GammaParticle(35089.0, 0.03533)), new(0.00615971497977019d, new GammaParticle(35414.0, 0.03501)), new(0.001208175606964571d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    