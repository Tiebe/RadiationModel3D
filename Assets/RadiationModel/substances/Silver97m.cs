using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver97m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver97m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.92454d;

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
    