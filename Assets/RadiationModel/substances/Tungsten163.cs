using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten163 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten163";
        public override double halfLife { get; } = 2.67d;
        public override double atomicWeight { get; } = 162.96252d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium163()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium159()), new(1.0d, new AlphaParticle(6540002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    