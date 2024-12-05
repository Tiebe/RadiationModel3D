using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium211m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium211m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 210.99816d;

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
    