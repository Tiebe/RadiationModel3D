using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium215m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 215.00473d;

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
    