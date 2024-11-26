using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium166";
        public override double halfLife { get; } = 2.25d;
        public override double atomicWeight { get; } = 165.96582d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.76d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum166()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.24d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum162()), new(1.0d, new AlphaParticle(6537002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    