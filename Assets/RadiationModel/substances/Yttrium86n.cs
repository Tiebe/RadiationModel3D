using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium86n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium86n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 85.91521d;

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
    