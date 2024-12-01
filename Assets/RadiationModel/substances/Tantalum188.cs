using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum188 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum188";
        public override double halfLife { get; } = 19.6d;
        public override double atomicWeight { get; } = 187.9636d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten188()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    