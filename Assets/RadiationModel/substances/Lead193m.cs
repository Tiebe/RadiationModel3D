using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead193m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead193m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 192.97623d;

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
    