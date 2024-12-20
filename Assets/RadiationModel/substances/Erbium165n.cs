using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium165n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium165n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 164.93269d;

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
    