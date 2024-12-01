using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium222";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 222.03357d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium218()), new(1.0d, new AlphaParticle(11217002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    