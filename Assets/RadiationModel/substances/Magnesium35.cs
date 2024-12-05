using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Magnesium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium35";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 35.01679d;

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
    