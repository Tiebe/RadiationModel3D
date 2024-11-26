using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium290";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 290.19187d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copernicium286()), new(1.0d, new AlphaParticle(10877002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    