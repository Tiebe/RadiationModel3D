using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Aluminum26m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum26m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 25.98714d;

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
    