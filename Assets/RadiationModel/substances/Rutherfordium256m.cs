using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium256m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 256.10235d;

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
    