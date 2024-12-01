using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium84";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 83.91342d;

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
    