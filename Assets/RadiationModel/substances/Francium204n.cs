using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium204n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204n";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 204.001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.74d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine200()), new(1.0d, new AlphaParticle(8519002.09)) } },
            { 0.26d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine204()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    