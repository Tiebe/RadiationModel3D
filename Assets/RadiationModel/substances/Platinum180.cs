using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum180 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum180";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 179.96304d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium180()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium176()), new(1.0d, new AlphaParticle(6298002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    