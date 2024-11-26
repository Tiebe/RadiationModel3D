using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 157.96659d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium154()), new(1.0d, new AlphaParticle(7147002.09)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    