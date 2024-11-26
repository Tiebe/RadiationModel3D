using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium86";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 85.96376d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium86()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.07d, new GammaParticle(527000.0, 0.00235)) } },
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium86()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.07d, new GammaParticle(527000.0, 0.00235)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium84()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new NeutronParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    