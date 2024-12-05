using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 130.92697d;

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
    