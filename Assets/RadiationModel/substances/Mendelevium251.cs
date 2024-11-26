using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium251";
        public override double halfLife { get; } = 256.2d;
        public override double atomicWeight { get; } = 251.08477d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium251()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium247()), new(1.0d, new AlphaParticle(8986002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    