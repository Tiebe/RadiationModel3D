using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium14p : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium14p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 14.04452d;

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
    