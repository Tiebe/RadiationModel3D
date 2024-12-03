using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium170m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 169.95831d;

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
    