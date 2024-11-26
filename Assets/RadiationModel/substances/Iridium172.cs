using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium172";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 171.97061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium172() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium168() }, { 1.0d, new AlphaParticle(7007002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    