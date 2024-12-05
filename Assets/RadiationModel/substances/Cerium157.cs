using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium157";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 156.95713d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    