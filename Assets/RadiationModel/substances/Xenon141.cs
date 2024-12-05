using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon141 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon141";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 140.92679d;

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
    