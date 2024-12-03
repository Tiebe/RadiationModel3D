using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium183m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 182.9551d;

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
    