using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium84";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 83.95266d;

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
    