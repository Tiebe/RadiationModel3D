using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neon21 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon21";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 20.99385d;

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
    