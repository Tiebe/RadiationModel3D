using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum36 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum36";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 36.00639d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon36() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.31d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon36() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    