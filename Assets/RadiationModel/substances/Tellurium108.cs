using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium108";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 107.92938d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.51d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin108()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.49d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin104()), new(1.0d, new AlphaParticle(4442002.09)) } },
            { 0.024d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin107()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    