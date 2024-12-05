using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium64";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 63.93684d;

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
    