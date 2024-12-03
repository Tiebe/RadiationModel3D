using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium94";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.92639d;

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
    