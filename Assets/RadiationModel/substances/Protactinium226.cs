using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium226";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 226.02795d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.74d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium222()), new(1.0d, new AlphaParticle(8009002.09)) } },
            { 0.26d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium226()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    