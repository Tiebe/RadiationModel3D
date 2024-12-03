using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 215.00272d;

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
    