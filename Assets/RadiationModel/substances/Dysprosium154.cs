using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium154";
        public override double halfLife { get; } = 94670777923776.0d;
        public override double atomicWeight { get; } = 153.92443d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium150()), new(1.0d, new AlphaParticle(3967002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    