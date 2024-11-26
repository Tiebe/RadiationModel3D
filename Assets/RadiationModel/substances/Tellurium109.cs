using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium109";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 108.9273d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.961d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin109()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.094d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin108()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },
            { 0.039d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin105()), new(1.0d, new AlphaParticle(4220002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    