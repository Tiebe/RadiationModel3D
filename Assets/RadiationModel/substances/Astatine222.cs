using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine222 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine222";
        public override double halfLife { get; } = 54.0d;
        public override double atomicWeight { get; } = 222.02249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon222()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    