using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium171";
        public override double halfLife { get; } = 53.0d;
        public override double atomicWeight { get; } = 170.94147d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium171()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    