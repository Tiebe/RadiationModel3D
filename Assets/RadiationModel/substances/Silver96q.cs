using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver96q : RadioactiveSubstance
    {
        public override string name { get; } = "Silver96q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.93821d;

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
    