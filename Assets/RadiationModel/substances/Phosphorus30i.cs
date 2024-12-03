using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus30i : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus30i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 29.97904d;

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
    