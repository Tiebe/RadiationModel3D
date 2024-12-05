using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium189";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 188.97357d;

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
    