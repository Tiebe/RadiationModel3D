using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead217 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead217";
        public override double halfLife { get; } = 19.9d;
        public override double atomicWeight { get; } = 217.01316d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth217()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    