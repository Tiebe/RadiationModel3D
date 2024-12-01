using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium237";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 237.05363d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium237()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    