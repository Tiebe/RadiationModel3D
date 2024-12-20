using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver127 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver127";
        public override double halfLife { get; } = 0.109d;
        public override double atomicWeight { get; } = 126.93704d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    