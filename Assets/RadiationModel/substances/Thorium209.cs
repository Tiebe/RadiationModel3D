using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium209";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 209.01761d;

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
    