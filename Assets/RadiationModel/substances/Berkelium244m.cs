using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium244m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 244.06679d;

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
    