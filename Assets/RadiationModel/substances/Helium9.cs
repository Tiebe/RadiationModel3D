using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Helium9 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium9";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.04395d;

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
    