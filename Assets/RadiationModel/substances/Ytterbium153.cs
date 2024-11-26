using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium153";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 152.94937d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium153()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium149()), new(1.0d, new AlphaParticle(5179002.09)) } },
            { 8e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium152()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    