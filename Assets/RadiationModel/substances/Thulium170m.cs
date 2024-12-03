using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium170m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 169.936d;

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
    