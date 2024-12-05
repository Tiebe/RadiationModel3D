using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium85";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 84.94297d;

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
    