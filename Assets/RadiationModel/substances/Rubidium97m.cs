using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium97m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.93726d;

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
    