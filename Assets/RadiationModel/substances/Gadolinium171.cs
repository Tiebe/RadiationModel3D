using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium171";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.96113d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium171()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    