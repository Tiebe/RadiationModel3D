using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium101";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 100.92146d;

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
    