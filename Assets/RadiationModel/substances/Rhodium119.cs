using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium119";
        public override double halfLife { get; } = 0.171d;
        public override double atomicWeight { get; } = 118.93256d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium119()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.064d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium119()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    