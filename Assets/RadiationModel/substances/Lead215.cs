using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead215 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead215";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 215.00466d;

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
    