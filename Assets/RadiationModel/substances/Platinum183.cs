using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 182.9616d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium183()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 9.599999999999999e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium179()), new(1.0d, new AlphaParticle(5844002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    