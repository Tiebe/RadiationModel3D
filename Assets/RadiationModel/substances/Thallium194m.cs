using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium194m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 193.97136d;

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
    