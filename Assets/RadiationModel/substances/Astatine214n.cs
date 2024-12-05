using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine214n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine214n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 213.99662d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth210()), new(1.0d, new AlphaParticle(10241902.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    