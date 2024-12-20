using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium258m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium258m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 258.10471d;

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
    