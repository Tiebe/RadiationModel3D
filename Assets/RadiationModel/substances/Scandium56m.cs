using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium56m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium56m";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 55.9726d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium56()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.18d, new GammaParticle(689600.0, 0.0018)), new(0.08d, new GammaParticle(750900.0, 0.00165)), new(0.3d, new GammaParticle(1128700.0, 0.0011)), new(0.18d, new GammaParticle(1128700.0, 0.0011)), new(0.3d, new GammaParticle(1160600.0, 0.00107)), new(0.06d, new GammaParticle(1466800.0, 0.00085)), new(0.03d, new GammaParticle(1494800.0, 0.00083)), new(0.03d, new GammaParticle(1711600.0, 0.00072)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    