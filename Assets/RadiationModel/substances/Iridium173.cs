using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium173";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 172.96751d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.93d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium169()), new(1.0d, new AlphaParticle(6738002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    