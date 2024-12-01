using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium83";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 82.93815d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium83()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    