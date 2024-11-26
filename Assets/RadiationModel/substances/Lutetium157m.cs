using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium157m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium157m";
        public override double halfLife { get; } = 4.79d;
        public override double atomicWeight { get; } = 156.95017d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium157()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium153()), new(1.0d, new AlphaParticle(6151002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    