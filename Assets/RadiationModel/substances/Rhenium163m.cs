using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium163m";
        public override double halfLife { get; } = 0.214d;
        public override double atomicWeight { get; } = 162.97221d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.66d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum159()), new(1.0d, new AlphaParticle(7154002.09)) } },
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum163()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    