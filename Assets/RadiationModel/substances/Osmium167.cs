using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium167";
        public override double halfLife { get; } = 0.839d;
        public override double atomicWeight { get; } = 166.97155d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.51d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten163()), new(1.0d, new AlphaParticle(7007002.09)) } },
            { 0.49d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten167()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    