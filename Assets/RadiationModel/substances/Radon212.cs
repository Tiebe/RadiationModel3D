using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon212 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon212";
        public override double halfLife { get; } = 1434.0d;
        public override double atomicWeight { get; } = 211.9907d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium208()), new(1.0d, new AlphaParticle(7407202.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    