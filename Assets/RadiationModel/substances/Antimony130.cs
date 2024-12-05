using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony130 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.91166d;

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
    