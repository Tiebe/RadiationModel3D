using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171";
        public override double halfLife { get; } = 43560.0d;
        public override double atomicWeight { get; } = 170.94049d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium171()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    