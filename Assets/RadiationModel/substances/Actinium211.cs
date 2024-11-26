using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium211";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 211.00767d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium207()), new(1.0d, new AlphaParticle(8586002.09)) } },
            { 0.002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium211()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    