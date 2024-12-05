using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium193m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 192.99117d;

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
    