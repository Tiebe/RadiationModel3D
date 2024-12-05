using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium141m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 140.93253d;

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
    