using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon115 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon115";
        public override double halfLife { get; } = 18.0d;
        public override double atomicWeight { get; } = 114.92629d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium115() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0034000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium114() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },
            { 2.9999999999999997e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium111() }, { 1.0d, new AlphaParticle(3527002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    