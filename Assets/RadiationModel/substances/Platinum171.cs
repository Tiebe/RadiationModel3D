using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum171 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum171";
        public override double halfLife { get; } = 0.0455d;
        public override double atomicWeight { get; } = 170.98125d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium167() }, { 1.0d, new AlphaParticle(7627002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium171() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    