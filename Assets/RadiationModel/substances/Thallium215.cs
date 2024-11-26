using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium215";
        public override double halfLife { get; } = 9.7d;
        public override double atomicWeight { get; } = 215.01077d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead215()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.046d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead215()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    