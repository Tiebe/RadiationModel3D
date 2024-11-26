using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury180 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury180";
        public override double halfLife { get; } = 2.59d;
        public override double atomicWeight { get; } = 179.97826d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.52d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum180()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.48d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum176()), new(1.0d, new AlphaParticle(7280002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    