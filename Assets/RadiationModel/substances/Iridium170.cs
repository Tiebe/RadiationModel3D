using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium170";
        public override double halfLife { get; } = 0.87d;
        public override double atomicWeight { get; } = 169.97512d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.948d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium170()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.052000000000000005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium166()), new(1.0d, new AlphaParticle(7257002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    