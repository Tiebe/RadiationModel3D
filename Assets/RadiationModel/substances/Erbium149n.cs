using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium149n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 148.94511d;

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
    