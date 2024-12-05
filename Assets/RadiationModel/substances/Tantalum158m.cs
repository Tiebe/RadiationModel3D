using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 157.96674d;

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
    