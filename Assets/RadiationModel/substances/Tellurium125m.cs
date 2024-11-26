using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium125m";
        public override double halfLife { get; } = 4959360.0d;
        public override double atomicWeight { get; } = 124.90459d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium125()), new(0.073d, new GammaParticle(35504.0, 0.03492)), new(0.0028000000000000004d, new GammaParticle(109276.0, 0.01135)), new(3.9e-09d, new GammaParticle(144780.0, 0.00856)), new(0.15047414111972388d, new GammaParticle(4135.0, 0.29984)), new(0.3416087306010647d, new GammaParticle(27202.0, 0.04558)), new(0.6361428875252603d, new GammaParticle(27473.0, 0.04513)), new(0.1820530128738087d, new GammaParticle(31093.0, 0.03988)), new(0.2215585166674252d, new GammaParticle(31359.0, 0.03954)), new(0.03950550379361649d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    