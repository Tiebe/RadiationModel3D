using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium163";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 162.9341d;

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
    