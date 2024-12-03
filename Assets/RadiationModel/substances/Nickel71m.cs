using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel71m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel71m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 70.94052d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper71()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.4d, new GammaParticle(454000.0, 0.00273)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    