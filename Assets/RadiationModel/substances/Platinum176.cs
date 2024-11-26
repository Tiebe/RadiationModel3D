using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum176 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum176";
        public override double halfLife { get; } = 6.33d;
        public override double atomicWeight { get; } = 175.96894d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium176() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium172() }, { 1.0d, new AlphaParticle(6907002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    