using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium259q : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium259q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 259.10582d;

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
    