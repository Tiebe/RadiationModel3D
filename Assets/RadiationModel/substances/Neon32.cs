using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon32";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 32.03972d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium32() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    