using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon37 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon37";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 36.99295d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Phosphorus37()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.17d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Phosphorus37()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    