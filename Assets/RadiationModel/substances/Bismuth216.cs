using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth216 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth216";
        public override double halfLife { get; } = 135.0d;
        public override double atomicWeight { get; } = 216.00631d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium216()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    