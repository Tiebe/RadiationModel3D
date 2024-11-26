using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195m";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 194.98108d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.67d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.33d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium191()), new(1.0d, new AlphaParticle(7254002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    