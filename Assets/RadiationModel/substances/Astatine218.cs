using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine218 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine218";
        public override double halfLife { get; } = 1.28d;
        public override double atomicWeight { get; } = 218.0087d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth214()), new(1.0d, new AlphaParticle(7898002.09)) } },
            { 0.0005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon218()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    