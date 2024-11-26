using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium177";
        public override double halfLife { get; } = 29.8d;
        public override double atomicWeight { get; } = 176.9613d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9994d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium173()), new(1.0d, new AlphaParticle(6104002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    