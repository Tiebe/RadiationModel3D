using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen12i : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen12i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.03176d;

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
    