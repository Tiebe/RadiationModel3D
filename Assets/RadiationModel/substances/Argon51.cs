using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon51 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon51";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 50.99303d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium51()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    