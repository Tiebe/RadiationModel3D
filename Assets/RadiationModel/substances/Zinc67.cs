using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc67 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc67";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 66.92713d;

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
    