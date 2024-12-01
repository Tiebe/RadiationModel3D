using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium221";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 221.02632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium217()), new(1.0d, new AlphaParticle(10911002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    