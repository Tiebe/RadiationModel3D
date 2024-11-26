using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine47 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine47";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 46.98972d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon47() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon47() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    