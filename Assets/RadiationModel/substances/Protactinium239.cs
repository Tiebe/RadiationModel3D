using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium239";
        public override double halfLife { get; } = 6480.0d;
        public override double atomicWeight { get; } = 239.05726d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium239()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    