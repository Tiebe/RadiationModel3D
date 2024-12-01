using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium144";
        public override double halfLife { get; } = 7.226536048181568e+22d;
        public override double atomicWeight { get; } = 143.91009d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium140()), new(1.0d, new AlphaParticle(2923202.0900000003)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    