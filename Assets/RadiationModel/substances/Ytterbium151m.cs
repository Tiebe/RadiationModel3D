using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 150.9562d;

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
    