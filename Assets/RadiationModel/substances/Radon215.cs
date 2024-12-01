using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon215 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon215";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 214.99875d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium211()), new(1.0d, new AlphaParticle(9860502.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    