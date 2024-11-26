using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202";
        public override double halfLife { get; } = 184.0d;
        public override double atomicWeight { get; } = 201.98863d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth202()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth198()), new(1.0d, new AlphaParticle(7376002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    