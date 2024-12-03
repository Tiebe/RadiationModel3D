using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead198m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead198m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 197.97431d;

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
    