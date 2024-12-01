using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chlorine36i : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine36i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 35.97292d;

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
    