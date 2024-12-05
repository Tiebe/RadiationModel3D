using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium123m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 122.91891d;

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
    