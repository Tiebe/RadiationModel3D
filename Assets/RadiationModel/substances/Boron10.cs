using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Boron10 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron10";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 10.01294d;

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
    