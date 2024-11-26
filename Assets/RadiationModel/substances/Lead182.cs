using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead182 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead182";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 181.99267d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury178() }, { 1.0d, new AlphaParticle(8087002.09) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury182() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    