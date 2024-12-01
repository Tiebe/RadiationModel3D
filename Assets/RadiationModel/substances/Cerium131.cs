using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium131";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 130.91443d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium131()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum131()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    