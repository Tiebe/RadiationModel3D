using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth193 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193";
        public override double halfLife { get; } = 63.6d;
        public override double atomicWeight { get; } = 192.98295d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.965d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium193()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.035d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium189()), new(1.0d, new AlphaParticle(7328002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    