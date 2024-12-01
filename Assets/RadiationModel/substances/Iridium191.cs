using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 190.96059d;

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
    