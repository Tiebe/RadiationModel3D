using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony130n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.91175d;

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
    