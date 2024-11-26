using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth194 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194";
        public override double halfLife { get; } = 95.0d;
        public override double atomicWeight { get; } = 193.9828d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9954000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium194()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0046d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium190()), new(1.0d, new AlphaParticle(6940002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    