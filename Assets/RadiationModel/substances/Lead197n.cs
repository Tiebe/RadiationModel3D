using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead197n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead197n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 196.97549d;

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
    