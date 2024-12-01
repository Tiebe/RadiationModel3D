using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium88";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.90561d;

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
    