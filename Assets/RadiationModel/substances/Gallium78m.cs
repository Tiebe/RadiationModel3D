using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium78m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium78m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.93215d;

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
    