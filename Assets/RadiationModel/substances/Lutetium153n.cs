using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium153n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium153n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 152.96148d;

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
    