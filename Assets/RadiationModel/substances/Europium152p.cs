using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium152p : RadioactiveSubstance
    {
        public override string name { get; } = "Europium152p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 151.92183d;

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
    