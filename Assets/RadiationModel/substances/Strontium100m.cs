using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium100m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 99.93752d;

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
    