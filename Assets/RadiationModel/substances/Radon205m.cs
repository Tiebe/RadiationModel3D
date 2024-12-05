using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon205m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon205m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 204.99243d;

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
    