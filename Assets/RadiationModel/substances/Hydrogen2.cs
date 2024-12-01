using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hydrogen2 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen2";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 2.0141d;

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
    