using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium277";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 277.15178d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new AlphaParticle(254437867249.94)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    