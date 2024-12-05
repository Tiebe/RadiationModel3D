using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver119m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver119m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 118.91559d;

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
    