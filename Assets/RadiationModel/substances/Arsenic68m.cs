using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic68m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic68m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 67.93723d;

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
    