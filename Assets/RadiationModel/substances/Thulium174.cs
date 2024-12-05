using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium174";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 173.94218d;

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
    