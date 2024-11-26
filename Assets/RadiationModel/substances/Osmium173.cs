using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium173";
        public override double halfLife { get; } = 22.4d;
        public override double atomicWeight { get; } = 172.95981d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten169()), new(1.0d, new AlphaParticle(6077002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    