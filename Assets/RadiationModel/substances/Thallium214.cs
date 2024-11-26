using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium214";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 214.00695d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead214() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead214() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    