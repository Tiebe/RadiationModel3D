using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine112 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine112";
        public override double halfLife { get; } = 3.34d;
        public override double atomicWeight { get; } = 111.928d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony112()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0088d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony111()), new(1.0d, new ProtonParticle()) } },
            { 0.00104d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin108()), new(1.0d, new AlphaParticle(13604002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    