using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony118n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony118n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 117.9058d;

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
    