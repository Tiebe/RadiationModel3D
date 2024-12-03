using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium81";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 80.93813d;

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
    