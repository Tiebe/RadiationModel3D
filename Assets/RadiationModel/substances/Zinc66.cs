using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc66 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc66";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 65.92603d;

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
    