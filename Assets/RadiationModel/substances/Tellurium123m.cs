using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium123m";
        public override double halfLife { get; } = 10298880.0d;
        public override double atomicWeight { get; } = 122.90454d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium123()), new(0.00092675d, new GammaParticle(88460.0, 0.01402)), new(0.8425d, new GammaParticle(159000.0, 0.0078)), new(3.45425e-06d, new GammaParticle(247500.0, 0.00501)), new(0.08726732607618701d, new GammaParticle(4135.0, 0.29984)), new(0.1449299838522713d, new GammaParticle(27202.0, 0.04558)), new(0.26988823808616624d, new GammaParticle(27473.0, 0.04513)), new(0.07723731231820045d, new GammaParticle(31093.0, 0.03988)), new(0.09399780909124995d, new GammaParticle(31359.0, 0.03954)), new(0.0167604967730495d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    