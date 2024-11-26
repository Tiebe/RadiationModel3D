using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium168";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 167.9678d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.57d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten168()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten164()), new(1.0d, new AlphaParticle(6838002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    